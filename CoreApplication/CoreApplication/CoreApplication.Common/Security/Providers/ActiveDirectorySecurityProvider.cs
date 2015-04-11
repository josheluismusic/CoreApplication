using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices.AccountManagement;
using CoreApplication.Common.Exceptions;
using System.Configuration;
using CoreApplication.Common.Tracing;

namespace CoreApplication.Common.Security.Providers
{
    public class ActiveDirectorySecurityProvider : IPasswordProvider, IAuthenticationProvider
    {
        public ActiveDirectorySecurityProvider()
        {
            Initialize();
        }

        public void Initialize()
        {
            var connString = ConfigurationManager.AppSettings[Defaults.ADConnectionStringSetting];

            if (String.IsNullOrWhiteSpace(connString))
                throw new NucleoCommonException("Ha ocurrido un error durante la inicialización del proveedor de seguridad de Active Directory: el string de conexión a AD es inválido. Verifique que exista la entrada [{0}] en el archivo de configuración y esta sea válida.", Defaults.ADConnectionStringSetting);

            Uri uri;
            if (!Uri.TryCreate(connString, UriKind.Absolute, out uri))
                throw new NucleoCommonException("Ha ocurrido un error durante la inicialización del proveedor de seguridad de Active Directory: el string de conexión a AD es inválido. Verifique que exista la entrada [{0}] en el archivo de configuración y esta sea válida.", Defaults.ADConnectionStringSetting);

            ActiveDirectoryUri = uri;

            _isInitialized = true;
        }

        private bool _isInitialized = false;

        public ClaimDictionary Authenticate(ClaimDictionary inputClaims)
        {
            if (!_isInitialized)
                throw new NucleoCommonException("El proveedor de seguridad de Active Directory no se encuentra inicializado. Posibles causas: No se encuentra configurado correctamente el string de conexión a AD.");

            // Traspaso los claims al diccionario de salida.
            Dictionary<string, object> outputClaims = new Dictionary<string, object>();
            foreach (var claim in inputClaims)
            {
                if (claim.Key == ClaimKeys.Password)
                    continue;

                outputClaims.Add(claim.Key, claim.Value);
            }

            // Verifico si el nombre de usuario es válido.
            var userName = inputClaims["UserName"] as string;
            if (String.IsNullOrWhiteSpace(userName))
            {
                Logger.Error("El nombre de usuario recibido es nulo o inválido. Verifique elemento \"UserName\" en el diccionario de evidencias enviadas al proveedor de seguridad de Active Directory.");
                outputClaims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.IncompleteData);
                return new ClaimDictionary(outputClaims);
            }

            
            // Verifico si la contraseña es válida
            var password = inputClaims["Password"] as string;
            if (String.IsNullOrEmpty(password))
            {
                Logger.Error("La contraseña recibida para autenticar al usuario [{0}] es nula. Verifique elemento \"Password\" en el diccionario de evidencias enviadas al proveedor de seguridad de active directory.", userName);
                outputClaims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.IncompleteData);
                return new ClaimDictionary(outputClaims);
            }


            // Obtengo el contexto de seguridad para AD-DS
            using (var context = new PrincipalContext(ContextType.Domain,
                        ActiveDirectoryUri.Authority,
                        ActiveDirectoryUri.AbsolutePath.Substring(1, ActiveDirectoryUri.AbsolutePath.Length - 1),
                        ContextOptions.Negotiate))
            {
                // Vaidación de credenciales en AD
                if (!context.ValidateCredentials(userName, password))
                {
                    outputClaims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.BadPassword);
                    return new ClaimDictionary(outputClaims);
                }

                // Obtengo datos del usuario
                using (var userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, userName))
                {
                    // Usuario no existe
                    if (userPrincipal == null)
                    {
                        Logger.Verbose("No se encontró la identidad [{0}] en Active Directory-", userName);
                        outputClaims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.UserDoesNotExists);
                        return new ClaimDictionary(outputClaims);
                    }

                    
                    outputClaims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.OK);
                    
                    // Verifico cuenta bloqueada
                    if (userPrincipal.IsAccountLockedOut())
                        outputClaims[ClaimKeys.AuthenticationStatus] = AuthenticationStatus.AccountLocked; 
                    
                    // Verifico cuenta expirada
                    if (userPrincipal.AccountExpirationDate.HasValue)
                        if (userPrincipal.AccountExpirationDate.Value > DateTime.Now)
                            outputClaims[ClaimKeys.AuthenticationStatus] = AuthenticationStatus.AccountExpired; 
    
                    
                    outputClaims.Add(ClaimKeys.FirstName, userPrincipal.Name);
                    outputClaims.Add(ClaimKeys.FathersName, userPrincipal.Surname);
                    outputClaims.Add(ClaimKeys.MothersName, userPrincipal.GivenName);
                    outputClaims.Add(ClaimKeys.TelephoneNumber , userPrincipal.VoiceTelephoneNumber);
                    outputClaims.Add(ClaimKeys.Email, userPrincipal.EmailAddress);

                    return new ClaimDictionary(outputClaims);
                }
            }
        }

        private Uri ActiveDirectoryUri { get; set; } 

        public ChangePasswordResult Change(NucleoIdentity identity, string password)
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace CoreApplication.Common.Security
{
    /// <summary>
    /// Clase que representa la identidad del Usuario
    /// Autor: Lagash S.A.
    /// Fecha de creación: 29/04/2013
    /// </summary>
    public class NucleoIdentity : IIdentity
    {
        public NucleoIdentity(WindowsIdentity identity)
        {
            Dictionary<string, object> claims = new Dictionary<string, object>();
            claims.Add(ClaimKeys.UserName, identity.Name);
            
            if (identity.IsAuthenticated)
                claims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.OK);
            else
                claims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.NotEspecified);

            Claims = new ClaimDictionary(claims);
        }

        /// <summary>
        /// Constructor interno de la clase
        /// </summary>
        /// <param name="claimDictionary">Claims del usuario</param>
        internal NucleoIdentity(ClaimDictionary claimDictionary)
        {
            Claims = claimDictionary;
        }

        /// <summary>
        /// Propiedad con los Claims del usuario
        /// </summary>
        public ClaimDictionary Claims { get; private set; }

        
        /// <summary>
        /// Propiedad con el tipo de autenticación 
        /// </summary>
        public string AuthenticationType
        {
            get
            {
                return "NucleoIdentity";
            }
        }

        /// <summary>
        /// Propiedad si el usuario debe cambiar contraseña
        /// </summary>
        public bool MustChangePassword
        {
            get
            {
                if (!Claims.ContainsKey(ClaimKeys.MustChangePassword))
                    return false;

                return (bool) Claims[ClaimKeys.MustChangePassword];
            }
        }

        /// <summary>
        /// Propiedad que identifica si el usuario se encuentra Autenticado
        /// </summary>
        public bool IsAuthenticated 
        { 
            get
            {
                if (!Claims.ContainsKey(ClaimKeys.AuthenticationStatus))
                    return false;
                
                var status = ((AuthenticationStatus)Enum.Parse(typeof(AuthenticationStatus),
                                Claims[ClaimKeys.AuthenticationStatus].ToString()));

                return status == AuthenticationStatus.OK;
            }
        }
 
        /// <summary>
        /// Propiedad que obtiene el nombre de la cuenta de usuario (UserName)
        /// </summary>
        public string Name 
        {
            get
            {
                return !Claims.ContainsKey(ClaimKeys.UserName) ? 
                    String.Empty : Claims[ClaimKeys.UserName].ToString();
            }
        }

        /// <summary>
        /// Propiedad que obtiene el nombre del usuario (FirstName)
        /// </summary>
        public string FirstName
        {
            get
            {
                return !Claims.ContainsKey(ClaimKeys.FirstName) ?
                    String.Empty : Claims[ClaimKeys.FirstName].ToString();
            }
        }

        /// <summary>
        /// Propiedad que obtiene el apellido paterno (FathersName)
        /// </summary>
        public string FathersName
        {
            get
            {
                return !Claims.ContainsKey(ClaimKeys.FathersName) ?
                    String.Empty : Claims[ClaimKeys.FathersName].ToString();
            }
        }

        /// <summary>
        /// Propiedad que obtiene el apellido materno (MothersName)
        /// </summary>
        public string MothersName
        {
            get
            {
                return !Claims.ContainsKey(ClaimKeys.MothersName) ?
                    String.Empty : Claims[ClaimKeys.MothersName].ToString();
            }
        }

        /// <summary>
        /// Propiedad que obtiene el Rut del usuario
        /// </summary>
        public string Rut
        {
            get
            {
                return !Claims.ContainsKey(ClaimKeys.Rut) ?
                    String.Empty : Claims[ClaimKeys.Rut].ToString();
            }
        }
 
    }

}

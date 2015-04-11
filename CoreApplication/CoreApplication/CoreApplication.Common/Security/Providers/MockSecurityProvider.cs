using CoreApplication.Common.Exceptions;
using CoreApplication.Common.Tracing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace CoreApplication.Common.Security.Providers
{
    public class MockSecurityProvider : IAuthorizationProvider, IAuthenticationProvider, IPasswordProvider, IAuditingProvider
    {

        public ClaimDictionary Authenticate(ClaimDictionary inputClaims)
        {
            var newClaims = new Dictionary<string, object>();

            foreach (var claim in inputClaims)
                newClaims.Add(claim.Key, claim.Value);
                
            if (!newClaims.ContainsKey(ClaimKeys.AuthenticationStatus))
                newClaims.Add(ClaimKeys.AuthenticationStatus, AuthenticationStatus.OK);
            
            if (!newClaims.ContainsKey(ClaimKeys.UserName))
                newClaims.Add(ClaimKeys.UserName, "MockUserName");

            if (!newClaims.ContainsKey(ClaimKeys.FirstName))
                newClaims.Add(ClaimKeys.FirstName, "MockNombre");

            if (!newClaims.ContainsKey(ClaimKeys.FathersName))
                newClaims.Add(ClaimKeys.FathersName, "MockApellidoPaterno");

            if (!newClaims.ContainsKey(ClaimKeys.MothersName))
                newClaims.Add(ClaimKeys.MothersName, "MockApellidoMaterno");

            if (!newClaims.ContainsKey(ClaimKeys.MustChangePassword))
                newClaims.Add(ClaimKeys.MustChangePassword, false);

            if (!newClaims.ContainsKey(ClaimKeys.Rut))
                newClaims.Add(ClaimKeys.Rut, "1-9");

            return new ClaimDictionary(newClaims);
        }

        public IEnumerable<string> GetPermissions(NucleoIdentity identity)
        {
            if (identity.Claims["mockPermissions"] != null)
                return identity.Claims["mockPermissions"] as IEnumerable<string>;

            return new List<string>();
        }

        public IEnumerable<string> GetPermissions(string identityName)
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            XDocument xml;

            try
            {
                var permissionsFilePath = Path.Combine(dir, "permissions.xml");
                xml = XDocument.Load(permissionsFilePath);
            }
            catch (Exception ex)
            {
                var nex = new NucleoCommonException(ex, "Ha ocurrido un error al intentar leer los permisos desde el archivo 'permissions.xml'. Por favor verifique que el mismo se encuentre en la ruta [{0}] y su formato corresponda al definido.", dir);
                Logger.Error(nex);
                throw nex;
            }


            IEnumerable<XElement> features;
            
            try
            {
                var permissions = xml.Element("authorization")
                                        .Element("identities")
                                        .Elements()
                                        .Where(e => e.Name == "identity" &&
                                        e.Attribute("name").Value == identityName)
                                        .FirstOrDefault();

                features = permissions
                                .Element("features")
                                .Elements()
                                .Where(e => e.Name == "feature");
            }
            catch (Exception ex)
            {
                var nex = new NucleoCommonException(ex, "Ha ocurrido un error al intentar obtener los permisos asociados al usuario [{0}]. Por favor verifique que el formato del archivos de permisos corresponda al definido.", identityName);
                Logger.Error(nex);
                throw nex;
            }

            foreach (var feature in features)
                yield return feature.Attribute("name").Value;

        }

        public ChangePasswordResult Change(NucleoIdentity identity, string password)
        {
            if (identity.IsAuthenticated)
                return ChangePasswordResult.Ok;

            return ChangePasswordResult.AccountDoesNotExists;
        }


        public void Audit(AuditEvent auditEvent)
        {
            return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApplication.Common.Security
{
    public static class ClaimKeys
    {
        public static string AuthenticationStatus = "AuthenticationStatus";
        public static string UserName = "UserName";
        public static string FirstName = "Nombre";
        public static string FathersName = "ApellidoPaterno";
        public static string MothersName = "ApellidoMaterno";
        public static string Rut = "Rut";
        public static string Email = "Email";
        public static string TelephoneNumber = "NumeroTelefono";
        public static string MustChangePassword = "MustChangePassword";
        public static string SessionTimeoutSeconds = "SessionTimeoutSeconds";
        public static string Password = "Password";
    }
}

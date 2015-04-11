using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CoreApplication.Common
{
    public class Defaults
    {
        // App Settings Keys
        internal const string DefaultExceptionPolicySetting = "CoreApplication.Common.DefaultExceptionPolicy";
        internal const string ApplicationNameSetting = "CoreApplication.Common.ApplicationName";
        internal const string ActiveTraceSourceSetting = "CoreApplication.Common.Trace.ActiveTraceSource";
        internal const string MockAuthenticationSetting = "CoreApplication.Common.Security.Authentication.MockMode";
        internal const string MockPasswordSetting = "CoreApplication.Common.Security.Password.MockMode";
        internal const string MockAuthorizationSetting = "CoreApplication.Common.Security.Authorization.MockMode";
        internal const string MockAuditingSetting = "CoreApplication.Common.Security.Auditing.MockMode";
        internal const string CryptoHelperKeySetting = "CoreApplication.Common.Utility.CryptoHelper.Key";
        internal const string PermissionsCacheSetting = "CoreApplication.Common.Security.PermissionsCache";
        internal const string ADConnectionStringSetting = "CoreApplication.Common.Security.ActiveDirectory.ConnectionString";
        
        // Este timeout no es configurable a propósito ya que es un dato que debiera proporcionarlo
        // el proveedor de autenticación
        internal const int DefaultSessionTimeout = 300;

        private static string _applicationName;
        public static string ApplicationName
        {
            get
            {
                if (_applicationName == null)
                {
                    if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings[ApplicationNameSetting]))
                        _applicationName = ConfigurationManager.AppSettings[ApplicationNameSetting];
                    else
                        _applicationName = AppDomain.CurrentDomain.FriendlyName;
                }

                return _applicationName;
            }
        }

        public static string DefaultTraceSource
        {
            get
            {
                string sourceName = ConfigurationManager.AppSettings[Defaults.ActiveTraceSourceSetting];

                if (sourceName == null)
                    sourceName = "CoreApplication.Common";

                return sourceName;
            }
        }

        public static string DefaultExceptionPolicy
        {
            get
            {
                string policyName = ConfigurationManager.AppSettings[Defaults.DefaultExceptionPolicySetting];

                if (policyName == null)
                    policyName = "CoreApplication.Common";
                
                return policyName;
            }
        }

 

    }
}

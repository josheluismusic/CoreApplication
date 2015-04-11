using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApplication.Common.Security.Providers
{
    public class Suser2AuthorizationProvider : IAuthorizationProvider
    {
        public IEnumerable<string> GetPermissions(string identityName)
        {
            throw new NotImplementedException();
        }

    }
}

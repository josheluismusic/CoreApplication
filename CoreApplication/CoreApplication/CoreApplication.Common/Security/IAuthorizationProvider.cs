using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApplication.Common.Security
{
    public interface IAuthorizationProvider
    {
        IEnumerable<string> GetPermissions(string identity);
    }

}

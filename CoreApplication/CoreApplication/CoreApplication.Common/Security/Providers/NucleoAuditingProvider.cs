using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApplication.Common.Security.Providers
{
    public class NucleoAuditingProvider : IAuditingProvider
    {
        public void Audit(AuditEvent auditEvent)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApplication.Common.Security
{
    public interface IAuditingProvider
    {
        void Audit(AuditEvent auditEvent);
    }

    public class AuditEvent
    {
        public AuditEvent(int auditEventId, string eventText, Dictionary<string, object> contextData)
        {
            UniqueId = Guid.NewGuid();
            AuditEventId = auditEventId;
            EventText = eventText;
        }

        public int AuditEventId { get; private set; }
        public Guid UniqueId { get; private set; }
        public string EventText { get; private set; }
        public ClaimDictionary Context { get; private set; }
    }


}

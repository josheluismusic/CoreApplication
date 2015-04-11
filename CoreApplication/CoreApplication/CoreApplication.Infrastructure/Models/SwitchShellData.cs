using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Infrastructure.Models
{
    public class SwitchShellData : Dictionary<string, object>
    {
        public SwitchShellData(ShellType shell)
            : this(shell, new Dictionary<string, object>())
        {
        }
        
        public SwitchShellData(ShellType shell, IDictionary<string, object> data)
            : base(data)
        {
            this.Shell = shell;
        }

        public ShellType Shell { get; private set; }
    }
}

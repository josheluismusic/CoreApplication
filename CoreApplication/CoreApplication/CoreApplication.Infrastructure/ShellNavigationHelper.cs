using CoreApplication.Infrastructure.Events;
using CoreApplication.Infrastructure.Models;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Infrastructure
{
    [Export]
    public class ShellNavigationHelper
    {
        private readonly SwitchShellEvent switchShellEvent;
        private readonly PacienteShellShowingEvent pacienteShellShowingEvent;

        [ImportingConstructor]
        public ShellNavigationHelper(IEventAggregator eventAggregator)
        {
            this.switchShellEvent = eventAggregator.GetEvent<SwitchShellEvent>();
            this.pacienteShellShowingEvent = eventAggregator.GetEvent<PacienteShellShowingEvent>();
        }


        public void SwitchShell(ShellType shellType)
        {
            SwitchShell(shellType, null);
        }

        public void SwitchShell(ShellType shellType, IDictionary<string, object> data)
        {
            switchShellEvent.Publish(new SwitchShellData(shellType, data ?? new Dictionary<string, object>()));
        }


        public PacienteShellShowingEvent PacienteShellShowingEvent
        {
            get { return this.pacienteShellShowingEvent; }
        }

        public SwitchShellEvent SwitchShellEvent
        {
            get { return this.switchShellEvent; }
        }
    }
}

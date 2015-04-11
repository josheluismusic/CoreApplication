using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Events;
using CoreApplication.Infrastructure.Models;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Mocks.BasicModule.ViewModels
{
    [Export]
    public class PacienteShellHeadViewModel : NotificationObject, IPartImportsSatisfiedNotification
    {
        private string fullName;
        private string info;

        [Import]
        private ShellNavigationHelper shellNavigationHelper;

        public string Info
        {
            get { return info; }
            set
            {
                info = value;
                RaisePropertyChanged(() => this.Info);
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                RaisePropertyChanged(() => this.FullName);
            }
        }

        public void OnImportsSatisfied()
        {
            PacienteShellShowingEvent pacienteShellShowingEvent = shellNavigationHelper.PacienteShellShowingEvent;
            pacienteShellShowingEvent.Subscribe(OnPacienteShellShowing, Microsoft.Practices.Prism.Events.ThreadOption.UIThread, false); 
        }

        void OnPacienteShellShowing(SwitchShellData data)
        {
            switch (data[Infrastructure.Defaults.SwitchShellIdPaciente].ToString())
            {
                case "1":
                    this.FullName = "JOSÉ LUIS CANDIA FIGUEROA";
                    this.Info = "RUT: 16617164-4   BOX: 45";

                    break;
                case "2":
                    this.FullName = "JUAN LUIS PEREZ PEREIRA";
                    this.Info = "RUT: 15656723-5   BOX: 33";

                    break;
                default:
                    break;
            }
        }
    }
}

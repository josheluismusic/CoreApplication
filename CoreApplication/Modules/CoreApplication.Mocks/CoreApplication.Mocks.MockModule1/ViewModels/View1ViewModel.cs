using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Events;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Infrastructure.Models;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoreApplication.Mocks.MockModule1.ViewModels
{
    [Export]
    public class View1ViewModel : NotificationObject, IPartImportsSatisfiedNotification, ITabInfoProvider
    {
        private readonly IEventAggregator eventAggregator;
        private readonly IRegionManager regionManager;

        [Import]
        private ShellNavigationHelper shellNavigationHelper;

        [ImportingConstructor]
        public View1ViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.eventAggregator = eventAggregator;
            this.PopupRegionCommand = new DelegateCommand(PopupRegion);
        }

        public void OnImportsSatisfied()
        {
            this.GoToPacienteShellCommand = new DelegateCommand<string>(GoToPacienteShell);
        }

        public DelegateCommand<string> GoToPacienteShellCommand { get; private set; }

        public DelegateCommand PopupRegionCommand { get; private set; }

        public void GoToPacienteShell(string id)
        {
            var data = new Dictionary<string, object>();
            data.Add(Infrastructure.Defaults.SwitchShellIdPaciente, id);
            data.Add(Infrastructure.Defaults.SwitchShellViewName, "Module1.View1");
            shellNavigationHelper.SwitchShell(ShellType.PacienteShell, data);
        }

        public void PopupRegion()
        {
            regionManager.RequestNavigate("PopupRegion", "MockModule1.View2");
        }

        public void ConfirmCloseTabRequest(Action<bool> confirmationCallback)
        {
            confirmationCallback(true);
        }

        public bool ShowCloseButton
        {
            get { return true; }
        }

        public string TabHeader
        {
            get { return "Module 1 - View 1"; }
        }
    }
}

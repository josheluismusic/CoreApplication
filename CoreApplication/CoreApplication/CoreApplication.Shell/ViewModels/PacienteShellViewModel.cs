using CoreApplication.Infrastructure;
using CoreApplication.Shell.Helpers;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Shell.ViewModels
{
    [Export]
    public class PacienteShellViewModel : NotificationObject, IPartImportsSatisfiedNotification
    {
        private readonly IRegionManager regionManager;

        [Import]
        private MenuHelper menuHelper;

        [ImportingConstructor]
        public PacienteShellViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.MainMenuItems = new List<MenuItemViewModel>();
            this.HelpMenuItems = new List<MenuItemViewModel>();
            this.StatsMenuItems = new List<MenuItemViewModel>();
            this.ConfigMenuItems = new List<MenuItemViewModel>();
        }

        public IList<MenuItemViewModel> MainMenuItems { get; set; }
        public IList<MenuItemViewModel> HelpMenuItems { get; set; }
        public IList<MenuItemViewModel> StatsMenuItems { get; set; }
        public IList<MenuItemViewModel> ConfigMenuItems { get; set; }

        public void OnImportsSatisfied()
        {
            this.MainMenuItems = menuHelper.GetMainMenuViewModel(ShellType.PacienteShell);
            this.HelpMenuItems = menuHelper.GetHelpMenuViewModel(ShellType.PacienteShell);
            this.StatsMenuItems = menuHelper.GetStatsMenuViewModel(ShellType.PacienteShell);
            this.ConfigMenuItems = menuHelper.GetConfigMenuViewModel(ShellType.PacienteShell);
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.Composition;
using CoreApplication.Infrastructure;
using CoreApplication.Shell.Helpers;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.ViewModel;

namespace CoreApplication.Shell.ViewModels
{
    [Export]
    public class ProfesionalShellViewModel : NotificationObject, IPartImportsSatisfiedNotification
    {
        private readonly IRegionManager regionManager;

        [Import]
        private MenuHelper menuHelper;

        [ImportingConstructor]
        public ProfesionalShellViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.MainMenuItems = new List<MenuItemViewModel>();
            this.StatsMenuItems = new List<MenuItemViewModel>();
            this.ConfigMenuItems = new List<MenuItemViewModel>();
            this.HelpMenuItems = new List<MenuItemViewModel>();
        }

        public IList<MenuItemViewModel> MainMenuItems { get; set; }
        public IList<MenuItemViewModel> StatsMenuItems { get; set; }
        public IList<MenuItemViewModel> ConfigMenuItems { get; set; }
        public IList<MenuItemViewModel> HelpMenuItems { get; set; }

        public void OnImportsSatisfied()
        {
            this.MainMenuItems = menuHelper.GetMainMenuViewModel(ShellType.ProfesionalShell);
            this.StatsMenuItems = menuHelper.GetStatsMenuViewModel(ShellType.ProfesionalShell);
            this.ConfigMenuItems = menuHelper.GetConfigMenuViewModel(ShellType.ProfesionalShell);
            this.HelpMenuItems = menuHelper.GetHelpMenuViewModel(ShellType.ProfesionalShell);
        }
    }
}

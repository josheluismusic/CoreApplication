using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows.Input;
using CoreApplication.Common.Security;
using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Commands;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Infrastructure.Models;
using CoreApplication.Shell.ViewModels;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Shell.Helpers
{
    [Export]
    public class MenuHelper
    {
        [ImportMany]
        private IEnumerable<Lazy<IModuleMenuProvider, IModuleMenuExportMetadata>> moduleMenuProviders;
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public MenuHelper(IRegionManager regionManager)
        {
            moduleMenuProviders = Enumerable.Empty<Lazy<IModuleMenuProvider, IModuleMenuExportMetadata>>();
            this.regionManager = regionManager;
        }

        public IList<MenuItemViewModel> GetMainMenuViewModel(ShellType shell)
        {
            var menus = GetMenuProviders(shell).SelectMany(m => m.Value.GetMainMenuItems());
            ICommand defaultCommand = GetDefaultCommand(shell);
            IList<MenuItemViewModel> viewModels = CreateViewModel(menus, defaultCommand);

            return viewModels;
        }

        public IList<MenuItemViewModel> GetHelpMenuViewModel(ShellType shell)
        {
            var menus = GetMenuProviders(shell).SelectMany(m => m.Value.GetHelpMenuItems());
            ICommand defaultCommand = GetDefaultCommand(shell);
            IList<MenuItemViewModel> viewModels = CreateViewModel(menus, defaultCommand);

            return viewModels;
        }

        public IList<MenuItemViewModel> GetStatsMenuViewModel(ShellType shell)
        {
            var menus = GetMenuProviders(shell).SelectMany(m => m.Value.GetStatsMenuItems());
            ICommand defaultCommand = GetDefaultCommand(shell);
            IList<MenuItemViewModel> viewModels = CreateViewModel(menus, defaultCommand);

            return viewModels;
        }

        public IList<MenuItemViewModel> GetConfigMenuViewModel(ShellType shell)
        {
            var menus = GetMenuProviders(shell).SelectMany(m => m.Value.GetConfigMenuItems());
            ICommand defaultCommand = GetDefaultCommand(shell);
            IList<MenuItemViewModel> viewModels = CreateViewModel(menus, defaultCommand);

            return viewModels;
        }

        private ICommand GetDefaultCommand(ShellType shell)
        {
            ICommand defaultCommand = null;

            switch (shell)
            {
                case ShellType.ProfesionalShell:
                    defaultCommand = new MenuCommand(regionManager, RegionNames.ProfesionalShellMainRegion);
                    break;
                case ShellType.PacienteShell:
                    defaultCommand = new MenuCommand(regionManager, RegionNames.PacienteShellMainRegion);
                    break;
                default:
                    break;
            }

            return defaultCommand;
        }

        private IEnumerable<Lazy<IModuleMenuProvider, IModuleMenuExportMetadata>> GetMenuProviders(ShellType shell)
        {
            var providers = moduleMenuProviders.Where(l => l.Metadata.Shell == shell);
            return providers;
        }

        private IList<MenuItemViewModel> CreateViewModel(IEnumerable<MenuItemModel> modelMenus, ICommand defaultCommand)
        {
            IList<MenuItemViewModel> menus = new List<MenuItemViewModel>();

            if (modelMenus != null && modelMenus.Any())
            {
                var group = modelMenus.OrderBy(sm => sm.Order).GroupBy(sm => sm.Title);
                foreach (var item in group)
                {
                    var menuItem = item.First();

                    if (String.IsNullOrEmpty(menuItem.Role) || SecurityManager.CurrentUser.IsInRole(menuItem.Role))
                    {
                        MenuItemViewModel viewModel = new MenuItemViewModel();
                        viewModel.Title = menuItem.Title;
                        viewModel.CommandArg = menuItem.CommandArg;
                        viewModel.Command = (menuItem.Command != null) ? menuItem.Command : defaultCommand;

                        viewModel.SubMenuItems = CreateViewModel(item.SelectMany(i => i.SubMenuItems), defaultCommand);
                        menus.Add(viewModel);
                    }
                }
            }

            return menus;
        }
    }
}

using CoreApplication.Common.Security;
using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Behaviors;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Infrastructure.Models;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Mocks.MockModule2.Menu
{
    [ModuleMenuExport(ShellType.ProfesionalShell)]
    public class ProfesionalShellMenuProvider : IModuleMenuProvider
    {
        public IList<MenuItemModel> GetMainMenuItems()
        {
            IList<MenuItemModel> moduleMenus = new List<MenuItemModel>();

            MenuItemModel module2 = new MenuItemModel("Module 2", String.Empty);
            module2.SubMenuItems.Add(new MenuItemModel("Module 2 - View 1", "MockModule2.View1"));
            module2.SubMenuItems.Add(new MenuItemModel("Module 2 - View 2", "MockModule2.View2"));

            MenuItemModel module1 = new MenuItemModel("Module 1", String.Empty);
            module1.SubMenuItems.Add(new MenuItemModel("Module 2 - View 2.2", "MockModule2.View22"));
            module1.SubMenuItems.Add(new MenuItemModel("Module 2 - View 1", "MockModule2.View1"));

            moduleMenus.Add(module2);
            moduleMenus.Add(module1);
            return moduleMenus;
        }

        public IList<MenuItemModel> GetHelpMenuItems()
        {
            IList<MenuItemModel> moduleMenus = new List<MenuItemModel>();

            return moduleMenus;
        }

        public IList<MenuItemModel> GetStatsMenuItems()
        {
            IList<MenuItemModel> moduleMenus = new List<MenuItemModel>();

            return moduleMenus;
        }

        public IList<MenuItemModel> GetConfigMenuItems()
        {
            IList<MenuItemModel> moduleMenus = new List<MenuItemModel>();

            return moduleMenus;
        }
    }
}

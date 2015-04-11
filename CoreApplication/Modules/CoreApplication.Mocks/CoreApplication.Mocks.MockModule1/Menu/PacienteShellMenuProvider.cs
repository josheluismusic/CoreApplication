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

namespace CoreApplication.Mocks.MockModule1.Menu
{
    [ModuleMenuExport(ShellType.PacienteShell)]
    public class PacienteShellMenuProvider : IModuleMenuProvider
    {
        public IList<MenuItemModel> GetMainMenuItems()
        {
            IList<MenuItemModel> moduleMenus = new List<MenuItemModel>();

            MenuItemModel module1 = new MenuItemModel("Module 1", String.Empty);
            module1.SubMenuItems.Add(new MenuItemModel("Module 1 - View 1", "MockModule1.View1"));
            module1.SubMenuItems.Add(new MenuItemModel("Module 1 - View 2", "MockModule1.View2"));

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

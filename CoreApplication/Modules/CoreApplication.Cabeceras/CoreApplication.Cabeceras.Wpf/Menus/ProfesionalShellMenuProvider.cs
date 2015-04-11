using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Behaviors;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Cabeceras.Wpf.Menus
{

    [ModuleMenuExport(ShellType.ProfesionalShell)]
    public class ProfesionalShellMenuProvider : IModuleMenuProvider
    {
        public IList<MenuItemModel> GetMainMenuItems()
        {
            IList<MenuItemModel> moduleMenus = new List<MenuItemModel>();

            MenuItemModel module1 = new MenuItemModel("Cabecera", String.Empty);
            module1.SubMenuItems.Add(new MenuItemModel("Cabecera Paciente", "Cabeceras.CabeceraPaciente"));

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

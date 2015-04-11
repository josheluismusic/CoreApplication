using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Behaviors;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Infrastructure.Models;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.Menu
{
    [ModuleMenuExport(ShellType.ProfesionalShell)]
    public class ProfesionalShellMenuProvider : IModuleMenuProvider
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public ProfesionalShellMenuProvider(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        #region IModuleMenuProvider Members

        public IList<MenuItemModel> GetMainMenuItems()
        {
            var output = new List<MenuItemModel>();

            output.Add(new MenuItemModel("Módulo 3", ""));
            output[0].SubMenuItems = new List<MenuItemModel>();

            output[0].SubMenuItems.Add(new MenuItemModel("Sample 1", "CoreApplication.Mocks.MockModule3.Views.Sample1.View1"));
            output[0].SubMenuItems.Add(new MenuItemModel("Sample 2", "CoreApplication.Mocks.MockModule3.Views.Sample2.View1"));
            output[0].SubMenuItems.Add(new MenuItemModel("Sample 3", "CoreApplication.Mocks.MockModule3.Views.Sample3.View1"));
            output[0].SubMenuItems.Add(new MenuItemModel("Sample 4", "CoreApplication.Mocks.MockModule3.Views.Sample4.View1"));

            var sample5 = new MenuItemModel("Sample 5", "");
            sample5.SubMenuItems.Add(new MenuItemModel("View 1", "CoreApplication.Mocks.MockModule3.Views.Sample5.View1"));
            sample5.SubMenuItems.Add(new MenuItemModel("View 2", "CoreApplication.Mocks.MockModule3.Views.Sample5.View2"));
            sample5.SubMenuItems.Add(new MenuItemModel("View 3", "CoreApplication.Mocks.MockModule3.Views.Sample5.View3"));
            output[0].SubMenuItems.Add(sample5);

            // menú de ejemplo
            output.Add(new MenuItemModel("Sample Menu", ""));
            output[1].SubMenuItems = new List<MenuItemModel>();

            for (int i = 1; i <= 10; i++)
                output[1].SubMenuItems.Add(new MenuItemModel("Menú Item " + i, ""));

            output[1].SubMenuItems[4].SubMenuItems = new List<MenuItemModel>();

            for (int i = 1; i <= 5; i++)
                output[1].SubMenuItems[4].SubMenuItems.Add(new MenuItemModel("Menú Item " + i, ""));

            output[1].SubMenuItems[4].SubMenuItems[2].SubMenuItems = new List<MenuItemModel>();

            for (int i = 1; i <= 50; i++)
                output[1].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item " + i, ""));

            return output;
        }

        public IList<MenuItemModel> GetStatsMenuItems()
        {
            var output = new List<MenuItemModel>();

            output.Add(new MenuItemModel("Números", ""));
            output.Add(new MenuItemModel("Comparación por servicio", ""));
            output.Add(new MenuItemModel("Menú Item 3", ""));

            output[2].SubMenuItems = new List<MenuItemModel>();

            for (int i = 1; i <= 10; i++)
                output[2].SubMenuItems.Add(new MenuItemModel("Menu Item " + i, ""));

            output[2].SubMenuItems[0].SubMenuItems = new List<MenuItemModel>();
            output[2].SubMenuItems[0].SubMenuItems.Add(new MenuItemModel("Menu Item 1", ""));
            output[2].SubMenuItems[0].SubMenuItems.Add(new MenuItemModel("Menu Item 2", ""));

            return output;
        }

        public IList<MenuItemModel> GetConfigMenuItems()
        {
            return Enumerable.Empty<MenuItemModel>().ToList();
        }

        public IList<MenuItemModel> GetHelpMenuItems()
        {
            return Enumerable.Empty<MenuItemModel>().ToList();
        }

        #endregion
    }
}

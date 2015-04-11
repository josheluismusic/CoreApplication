using System.Collections.Generic;
using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Behaviors;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Infrastructure.Models;

namespace CoreApplication.Mocks.BasicModule.Menu
{
    [ModuleMenuExport(ShellType.ProfesionalShell)]
    public class ProfesionalShellMenuProvider : IModuleMenuProvider
    {
        #region IModuleMenuProvider Members

        public IList<MenuItemModel> GetMainMenuItems()
        {
            var output = new List<MenuItemModel>();

            output.Add(new MenuItemModel("Portal Asistencial", ""));
            output.Add(new MenuItemModel("Mis Pacientes", ""));
            output.Add(new MenuItemModel("Agenda Ambulatoria", ""));
            output.Add(new MenuItemModel("Urgencia", ""));
            output.Add(new MenuItemModel("Hospitalizado", ""));
            output.Add(new MenuItemModel("Apps", ""));
            output.Add(new MenuItemModel("Menú de prueba", ""));

            for (int i = 1; i < output.Count; i++)
                output[i].SubMenuItems = new List<MenuItemModel>();

            output[1].SubMenuItems.Add(new MenuItemModel("Episodios Activos", ""));
            output[1].SubMenuItems.Add(new MenuItemModel("Pacientes Etiquetados", ""));
            output[1].SubMenuItems.Add(new MenuItemModel("Canales Virtuales", ""));

            output[2].SubMenuItems.Add(new MenuItemModel("Agenda/Búsqueda de pacientes", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Cancelación citas", ""));

            output[3].SubMenuItems.Add(new MenuItemModel("Listado", ""));
            output[3].SubMenuItems.Add(new MenuItemModel("Mapa de box", ""));
            output[3].SubMenuItems.Add(new MenuItemModel("Búsqueda de episodio", ""));
            output[3].SubMenuItems.Add(new MenuItemModel("Entrega/Recepción de turno", ""));

            output[4].SubMenuItems.Add(new MenuItemModel("Listado", ""));
            output[4].SubMenuItems.Add(new MenuItemModel("Mapa de box", ""));
            output[4].SubMenuItems.Add(new MenuItemModel("Búsqueda de episodio", ""));
            output[4].SubMenuItems.Add(new MenuItemModel("Entrega/Recepción de turno", ""));

            output[5].SubMenuItems.Add(new MenuItemModel("Correo electrónico", ""));
            output[5].SubMenuItems.Add(new MenuItemModel("Cuenta corriente", ""));
            output[5].SubMenuItems.Add(new MenuItemModel("Panel de farmacia", ""));
            output[5].SubMenuItems.Add(new MenuItemModel("Takyon", ""));

            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 1", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 2", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 3", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 4", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 5", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 6", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 7", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 8", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 9", ""));
            output[6].SubMenuItems.Add(new MenuItemModel("Menú Item 10", ""));

            output[6].SubMenuItems[4].SubMenuItems = new List<MenuItemModel>();

            output[6].SubMenuItems[4].SubMenuItems.Add(new MenuItemModel("Menú Item 1", ""));
            output[6].SubMenuItems[4].SubMenuItems.Add(new MenuItemModel("Menú Item 2", ""));
            output[6].SubMenuItems[4].SubMenuItems.Add(new MenuItemModel("Menú Item 3", ""));
            output[6].SubMenuItems[4].SubMenuItems.Add(new MenuItemModel("Menú Item 4", ""));

            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems = new List<MenuItemModel>();
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 1", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 2", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 3", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 4", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 5", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 6", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 7", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 8", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 9", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 10", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 11", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 12", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 13", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 14", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 15", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 16", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 17", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 18", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 19", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 20", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 21", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 22", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 23", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 24", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 25", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 26", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 27", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 28", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 29", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 30", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 31", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 32", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 33", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 34", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 35", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 36", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 37", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 38", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 39", ""));
            output[6].SubMenuItems[4].SubMenuItems[2].SubMenuItems.Add(new MenuItemModel("Menú Item 40", ""));

            return output;
        }

        public IList<MenuItemModel> GetStatsMenuItems()
        {
            var output = new List<MenuItemModel>();

            output.Add(new MenuItemModel("Números", ""));
            output.Add(new MenuItemModel("Comparación por servicio", ""));
            output.Add(new MenuItemModel("Menú Item 3", ""));

            output[2].SubMenuItems = new List<MenuItemModel>();
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 1", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 2", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 3", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 4", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 5", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 6", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 7", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 8", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 9", ""));
            output[2].SubMenuItems.Add(new MenuItemModel("Menu Item 10", ""));

            output[2].SubMenuItems[0].SubMenuItems = new List<MenuItemModel>();
            output[2].SubMenuItems[0].SubMenuItems.Add(new MenuItemModel("Menu Item 1", ""));
            output[2].SubMenuItems[0].SubMenuItems.Add(new MenuItemModel("Menu Item 2", ""));

            return output;
        }

        public IList<MenuItemModel> GetConfigMenuItems()
        {
            var output = new List<MenuItemModel>();

            output.Add(new MenuItemModel("Personalizar Portal Asistencial", ""));
            output.Add(new MenuItemModel("Personalizar Resumen", ""));
            output.Add(new MenuItemModel("Actualizar Mis Datos", ""));

            return output;
        }

        public IList<MenuItemModel> GetHelpMenuItems()
        {
            var output = new List<MenuItemModel>();

            output.Add(new MenuItemModel("Portal Asistencial", ""));
            output.Add(new MenuItemModel("Ambulatorio", ""));
            output.Add(new MenuItemModel("Urgencia", ""));
            output.Add(new MenuItemModel("Hospitalizado", ""));

            return output;
        }

        #endregion
    }
}

using System.Collections.Generic;
using CoreApplication.Infrastructure.Models;

namespace CoreApplication.Infrastructure.Interfaces
{
    public interface IModuleMenuProvider
    {
        IList<MenuItemModel> GetMainMenuItems();
        IList<MenuItemModel> GetStatsMenuItems();
        IList<MenuItemModel> GetConfigMenuItems();
        IList<MenuItemModel> GetHelpMenuItems();
    }
}

using System.Collections.Generic;
using System.Windows.Input;

namespace CoreApplication.Shell.ViewModels
{
    public class MenuItemViewModel
    {
        public MenuItemViewModel()
        {
            this.SubMenuItems = new List<MenuItemViewModel>();
        }

        public string Title { get; set; }
        public string CommandArg { get; set; }
        public ICommand Command { get; set; }
        public IList<MenuItemViewModel> SubMenuItems { get; set; }
    }
}

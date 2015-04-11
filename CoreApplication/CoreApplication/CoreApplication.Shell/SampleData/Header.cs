using System.Collections.Generic;
using System.Linq;
using CoreApplication.Shell.ViewModels;

namespace CoreApplication.Shell.SampleData
{
    public class Header
    {
        List<MenuItemViewModel> sample, main, stats, help;

        public Header()
        {
            sample = new List<MenuItemViewModel>();
            sample.Add(new MenuItemViewModel() { Title = "Opción 1" });
            sample.Add(new MenuItemViewModel() { Title = "Opción 2" });
            sample.Add(new MenuItemViewModel() { Title = "Opción 3" });
            sample.Add(new MenuItemViewModel() { Title = "Opción 4" });
            sample.Add(new MenuItemViewModel() { Title = "Opción 5" });

            main = new List<MenuItemViewModel>(sample);
            main[1].SubMenuItems = new List<MenuItemViewModel>(sample);
            main[2].SubMenuItems = new List<MenuItemViewModel>(sample);

            stats = new List<MenuItemViewModel>(sample);
            help = new List<MenuItemViewModel>(sample);
        }

        public IList<MenuItemViewModel> MainMenu
        {
            get { return this.main; }
        }

        public IList<MenuItemViewModel> StatsMenu
        {
            get { return this.stats; }
        }

        public IList<MenuItemViewModel> ConfigMenu
        {
            get { return Enumerable.Empty<MenuItemViewModel>().ToList(); }
        }

        public IList<MenuItemViewModel> HelpMenu
        {
            get { return this.help; }
        }
    }
}

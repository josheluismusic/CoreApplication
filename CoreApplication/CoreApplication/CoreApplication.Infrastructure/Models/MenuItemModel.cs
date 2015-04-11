using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoreApplication.Infrastructure.Models
{
    public class MenuItemModel
    {
        public MenuItemModel()
            :this(String.Empty, null, String.Empty) { }

        public MenuItemModel(string title, string viewName)
            :this(title, null, viewName) { }

        public MenuItemModel(string title, ICommand command)
            :this(title, command, String.Empty) { }

        public MenuItemModel(string title, ICommand command, string commandArg)
        {
            this.Title = title;
            this.CommandArg = commandArg;
            this.Command = command;
            this.SubMenuItems = new List<MenuItemModel>();
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Synonyms { get; set; }
		public string Role { get; set; }
        public string CommandArg { get; set; }
        public ICommand Command { get; set; }
        public IList<MenuItemModel> SubMenuItems { get; set; }
    }
}

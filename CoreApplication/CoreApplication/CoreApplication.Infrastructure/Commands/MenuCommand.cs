using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoreApplication.Infrastructure.Commands
{
    public class MenuCommand : ICommand
    {
        private readonly IRegionManager regionManager;
        private readonly string regionName;

        public MenuCommand(IRegionManager regionManager, string regionName)
        {
            this.regionManager = regionManager;
            this.regionName = regionName;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
            {
                regionManager.RequestNavigate(regionName, parameter.ToString(), LogException);
            }
        }

        void LogException(NavigationResult navigationResult)
        {
            bool? ok = navigationResult.Result;
        }
    }
}

using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Mocks.InitModule.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace CoreApplication.Mocks.InitModule
{
    [Export(typeof(IInitModule))]
    public class InitModule : IInitModule
    {
        private CompositionContainer container;

        [ImportingConstructor]
        public InitModule(CompositionContainer container)
        {
            this.container = container;
        }

        public void LoadPrincipal()
        {
            var loginWindow = container.GetExportedValue<LoginWindow>("InitModule.LoginWindow");
            
            bool? result = loginWindow.ShowDialog();
        }
    }
}

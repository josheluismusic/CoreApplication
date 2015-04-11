using CoreApplication.Mocks.InitModule.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace CoreApplication.Mocks.InitModule.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    [Export("InitModule.Login")]
    public partial class Login : RadWindow
    {
        [ImportingConstructor]
        public Login(LoginWindowViewModel vm)
        {
            InitializeComponent();
            
            this.DataContext = vm;
        }
    }
}

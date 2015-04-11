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

namespace CoreApplication.Mocks.InitModule.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    [Export("InitModule.LoginWindow")]
    public partial class LoginWindow : Window
    {
        [ImportingConstructor]
        public LoginWindow(LoginWindowViewModel vm)
        {
            InitializeComponent();
            
            this.DataContext = vm;
        }
    }
}

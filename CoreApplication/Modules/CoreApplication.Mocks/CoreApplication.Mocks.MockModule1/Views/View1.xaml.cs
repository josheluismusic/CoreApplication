using CoreApplication.Mocks.MockModule1.ViewModels;
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

namespace CoreApplication.Mocks.MockModule1.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    [Export("MockModule1.View1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class View1 : UserControl
    {
        [ImportingConstructor]
        public View1(View1ViewModel vm)
        {
            InitializeComponent();

            this.DataContext = vm;
        }
    }
}

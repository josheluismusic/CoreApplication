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

namespace CoreApplication.Mocks.MockModule2.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    [Export("MockModule2.View1")]
    public partial class View1 : UserControl
    {
        public View1()
        {
        }
    }
}

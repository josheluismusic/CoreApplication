using CoreApplication.Mocks.BasicModule.ViewModels;
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

namespace CoreApplication.Mocks.BasicModule
{
    /// <summary>
    /// Interaction logic for PacienteShellHead.xaml
    /// </summary>
    [Export]
    public partial class PacienteShellHead : UserControl
    {
        [ImportingConstructor]
        public PacienteShellHead(PacienteShellHeadViewModel vm)
        {
            InitializeComponent();

            this.DataContext = vm;
        }
    }
}

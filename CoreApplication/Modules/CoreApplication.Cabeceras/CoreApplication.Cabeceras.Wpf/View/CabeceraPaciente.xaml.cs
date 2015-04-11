using CoreApplication.Cabeceras.Wpf.ViewModel;
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

namespace CoreApplication.Cabeceras.Wpf.View
{ 
    /// <summary>
    /// Interaction logic for ListadoUrgencia.xaml
    /// </summary>
    [Export("Cabeceras.CabeceraPaciente")]
    public partial class CabeceraPaciente : UserControl
    {
        [ImportingConstructor]
        public CabeceraPaciente(CabeceraPacienteViewModel vm)
        {
            InitializeComponent();

            this.DataContext = vm;
        }
    }
}

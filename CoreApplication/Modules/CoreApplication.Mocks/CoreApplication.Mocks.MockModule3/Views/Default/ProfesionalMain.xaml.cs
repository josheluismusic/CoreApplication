using System.ComponentModel.Composition;
using System.Windows.Controls;
using CoreApplication.Mocks.MockModule3.ViewModels.Default;

namespace CoreApplication.Mocks.MockModule3.Views.Default
{
    [Export]
    public partial class ProfesionalMain : UserControl
    {
        [ImportingConstructor]
        public ProfesionalMain(ProfesionalMainViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}

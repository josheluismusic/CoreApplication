using System.ComponentModel.Composition;
using System.Windows.Controls;
using CoreApplication.Mocks.MockModule3.ViewModels.Sample5;

namespace CoreApplication.Mocks.MockModule3.Views.Sample5
{
    [Export]
    public partial class View3 : UserControl
    {
        [ImportingConstructor]
        public View3(View3ViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}

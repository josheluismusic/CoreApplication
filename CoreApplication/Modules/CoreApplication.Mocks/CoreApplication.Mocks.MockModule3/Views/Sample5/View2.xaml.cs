using System.ComponentModel.Composition;
using System.Windows.Controls;
using CoreApplication.Mocks.MockModule3.ViewModels.Sample5;

namespace CoreApplication.Mocks.MockModule3.Views.Sample5
{
    [Export]
    public partial class View2 : UserControl
    {
        [ImportingConstructor]
        public View2(View2ViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}

using System.ComponentModel.Composition;
using System.Windows.Controls;
using CoreApplication.Mocks.MockModule3.ViewModels.Sample4;

namespace CoreApplication.Mocks.MockModule3.Views.Sample4
{
    [Export]
    public partial class View4 : UserControl
    {
        [ImportingConstructor]
        public View4(View4ViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}

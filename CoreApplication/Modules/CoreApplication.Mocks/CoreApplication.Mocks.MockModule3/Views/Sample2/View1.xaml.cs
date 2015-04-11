using System.ComponentModel.Composition;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.Views.Sample2
{
    [Export]
    public partial class View1 : UserControl
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public View1(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }
    }
}

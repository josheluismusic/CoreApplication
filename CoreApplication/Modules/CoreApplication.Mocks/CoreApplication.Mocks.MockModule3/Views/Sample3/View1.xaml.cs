using System.ComponentModel.Composition;
using System.Windows.Controls;
using CoreApplication.Mocks.MockModule3.ViewModels.Sample3;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.Views.Sample3
{
    [Export]
    public partial class View1 : UserControl
    {
        [ImportingConstructor]
        public View1(View1ViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        IRegionManager regionManager;

        public IRegionManager RegionManager
        {
            get { return this.regionManager; }
            set { this.regionManager = value; }
        }
    }
}

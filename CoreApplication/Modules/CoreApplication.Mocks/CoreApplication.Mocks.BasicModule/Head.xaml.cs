using System.ComponentModel.Composition;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.BasicModule
{
    [Export]
    public partial class Head : UserControl
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public Head(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }
    }
}

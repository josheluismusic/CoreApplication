using System.ComponentModel.Composition;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.BasicModule
{
    [Export]
    public partial class Main : UserControl
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public Main(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }
    }
}

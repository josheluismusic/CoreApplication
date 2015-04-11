using System.ComponentModel.Composition;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.BasicModule
{
    [Export]
    public partial class Info : UserControl
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public Info(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }
    }
}

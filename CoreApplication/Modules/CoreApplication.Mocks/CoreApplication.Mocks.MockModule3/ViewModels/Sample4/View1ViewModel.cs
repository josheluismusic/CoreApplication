using System.ComponentModel.Composition;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Mocks.MockModule3.Views.Sample4;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample4
{
    [Export]
    public class View1ViewModel : IPartImportsSatisfiedNotification, IHeaderInfoProvider
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public View1ViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        #region IPartImportsSatisfiedNotification Members

        public void OnImportsSatisfied()
        {
            this.regionManager.RegisterViewWithRegion(MockModule3RegionNames.MainRegion, typeof(View2));
            //this.regionManager.RequestNavigate(MockModule3RegionNames.MainRegion,
            //    "CoreApplication.Mocks.MockModule3.Views.Sample4.View2");
        }

        #endregion

        #region IHeaderInfoProvider Members

        public string HeaderInfo
        {
            get { return "Sample 4- View 1"; }
        }

        #endregion
    }
}

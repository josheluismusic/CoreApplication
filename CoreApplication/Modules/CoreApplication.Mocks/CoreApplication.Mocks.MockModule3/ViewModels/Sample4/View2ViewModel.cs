using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample4
{
    [Export]
    public class View2ViewModel : IPartImportsSatisfiedNotification, INavigationAware
    {
        private readonly IRegionManager regionManager;
        private IRegionNavigationService navigationService;

        [ImportingConstructor]
        public View2ViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public DelegateCommand GoToView3Command { get; private set; }

        private void GoToView3()
        {
            this.regionManager.RequestNavigate(MockModule3RegionNames.MainRegion,
                "CoreApplication.Mocks.MockModule3.Views.Sample4.View3");
        }

        #region IPartImportsSatisfiedNotification Members

        public void OnImportsSatisfied()
        {
            this.GoToView3Command = new DelegateCommand(GoToView3);
        }

        #endregion

        #region INavigationAware Members

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            this.navigationService = navigationContext.NavigationService;
        }

        #endregion
    }
}

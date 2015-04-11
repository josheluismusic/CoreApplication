using System.ComponentModel.Composition;
using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Interfaces;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample3
{
    [Export]
    public class View3ViewModel : IPartImportsSatisfiedNotification, INavigationAware, IHeaderInfoProvider
    {
        private readonly IRegionManager regionManager;
        private IRegionNavigationService navigationService;

        [ImportingConstructor]
        public View3ViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public DelegateCommand GoBackCommand { get; private set; }

        public bool CanGoBack
        {
            get { return navigationService.Journal.CanGoBack; }
        }

        private void GoBack()
        {
            if (navigationService.Journal.CanGoBack)
                navigationService.Journal.GoBack();
        }

        #region IPartImportsSatisfiedNotification Members

        public void OnImportsSatisfied()
        {
            this.GoBackCommand = new DelegateCommand(GoBack);
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

        #region IHeaderInfoProvider Members

        public string HeaderInfo
        {
            get { return "Sample 3 - View 3"; }
        }

        #endregion
    }
}

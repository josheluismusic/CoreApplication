using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample4
{
    [Export]
    public class View4ViewModel : IPartImportsSatisfiedNotification, INavigationAware
    {
        private readonly IRegionManager regionManager;
        private IRegionNavigationService navigationService;

        [ImportingConstructor]
        public View4ViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public DelegateCommand GoBackCommand { get; private set; }

        public bool CanGoBack
        {
            get { return this.navigationService.Journal.CanGoBack; }
        }

        private void GoBack()
        {
            if (this.navigationService.Journal.CanGoBack)
                this.navigationService.Journal.GoBack();
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
    }
}

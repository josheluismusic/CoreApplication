using System.ComponentModel.Composition;
using CoreApplication.Infrastructure.Interfaces;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample4
{
    [Export]
    public class View3ViewModel : IPartImportsSatisfiedNotification, INavigationAware
    {
        private readonly IRegionManager regionManager;
        private IRegionNavigationService navigationService;

        [ImportingConstructor]
        public View3ViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public DelegateCommand GoToView4Command { get; private set; }
        public DelegateCommand GoBackCommand { get; private set; }

        public bool CanGoBack
        {
            get { return this.navigationService.Journal.CanGoBack; }
        }

        private void GoToView4()
        {
            this.regionManager.RequestNavigate(MockModule3RegionNames.MainRegion,
                "CoreApplication.Mocks.MockModule3.Views.Sample4.View4");
        }

        private void GoBack()
        {
            if (this.navigationService.Journal.CanGoBack)
                this.navigationService.Journal.GoBack();
        }

        #region IPartImportsSatisfiedNotification Members

        public void OnImportsSatisfied()
        {
            this.GoToView4Command = new DelegateCommand(GoToView4);
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

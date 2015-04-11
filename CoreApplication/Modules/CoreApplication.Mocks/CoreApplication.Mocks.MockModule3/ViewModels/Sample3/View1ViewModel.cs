using System.ComponentModel.Composition;
using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Interfaces;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample3
{
    [Export]
    public class View1ViewModel : IPartImportsSatisfiedNotification, ITabInfoProvider
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public View1ViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public DelegateCommand GoToView2Command { get; private set; }

        private void GoToView2()
        {
            this.regionManager.RequestNavigate(RegionNames.ProfesionalShellMainRegion,
                "CoreApplication.Mocks.MockModule3.Views.Sample3.View2");
        }

        #region IPartImportsSatisfiedNotification Members

        public void OnImportsSatisfied()
        {
            this.GoToView2Command = new DelegateCommand(GoToView2);
        }

        #endregion

        #region IHeaderInfoProvider Members

        public string HeaderInfo
        {
            get { return "Sample 3 - View 1"; }
        }

        #endregion

        #region ITabInfoProvider Members

        public string TabHeader
        {
            get { return "Sample 3 - View 1"; }
        }

        public bool ShowCloseButton
        {
            get { return true; }
        }

        public void ConfirmCloseTabRequest(System.Action<bool> confirmationCallback)
        {

        }

        #endregion
    }
}

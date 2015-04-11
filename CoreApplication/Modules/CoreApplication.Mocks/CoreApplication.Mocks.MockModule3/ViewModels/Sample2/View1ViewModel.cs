using System.ComponentModel.Composition;
using CoreApplication.Infrastructure.Interfaces;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample2
{
    [Export]
    public class View1ViewModel : ITabInfoProvider
    {
        #region ITabInfoProvider Members

        public string TabHeader
        {
            get { return "Sample 2 - View 1"; }
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

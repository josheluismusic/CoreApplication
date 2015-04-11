using System.ComponentModel.Composition;
using CoreApplication.Infrastructure.Interfaces;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample5
{
    [Export]
    public class View2ViewModel : ITabInfoProvider
    {
        #region ITabInfoProvider Members

        public string TabHeader
        {
            get { return "Sample 5 - View 2"; }
        }

        public bool ShowCloseButton
        {
            get { return true; }
        }

        public void ConfirmCloseTabRequest(System.Action<bool> confirmationCallback)
        {
            confirmationCallback(true);
        }

        #endregion
    }
}

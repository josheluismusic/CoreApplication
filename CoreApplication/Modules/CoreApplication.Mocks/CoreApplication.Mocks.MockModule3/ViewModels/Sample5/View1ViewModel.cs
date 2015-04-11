using System;
using System.ComponentModel.Composition;
using CoreApplication.Infrastructure.Interfaces;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample5
{
    [Export]
    public class View1ViewModel : ITabInfoProvider
    {
        #region ITabInfoProvider Members

        public string TabHeader
        {
            get { return "Sample 5 - View 1"; }
        }

        public bool ShowCloseButton
        {
            get { return false; }
        }

        public void ConfirmCloseTabRequest(Action<bool> confirmationCallback)
        {
        }

        #endregion
    }
}

using System;
using System.ComponentModel.Composition;
using CoreApplication.Infrastructure.Interfaces;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Default
{
    [Export]
    public class ProfesionalMainViewModel : ITabInfoProvider
    {
        #region ITabInfoProvider Members

        public string TabHeader
        {
            get { return "Atención"; }
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

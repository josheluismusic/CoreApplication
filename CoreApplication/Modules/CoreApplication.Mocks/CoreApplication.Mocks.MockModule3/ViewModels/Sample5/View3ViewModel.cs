using System;
using System.ComponentModel.Composition;
using System.Windows;
using CoreApplication.Infrastructure.Interfaces;

namespace CoreApplication.Mocks.MockModule3.ViewModels.Sample5
{
    [Export]
    public class View3ViewModel : ITabInfoProvider
    {
        #region ITabInfoProvider Members

        public string TabHeader
        {
            get { return "Sample 5 - View 3"; }
        }

        public bool ShowCloseButton
        {
            get { return true; }
        }

        public void ConfirmCloseTabRequest(Action<bool> confirmationCallback)
        {
            var result = MessageBox.Show("¿Está seguro que desea cerrar la pestaña?", "Pregunta",
                MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            confirmationCallback(result == MessageBoxResult.Yes);
        }

        #endregion
    }
}

using CoreApplication.Infrastructure.Interfaces;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoreApplication.Mocks.MockModule1.ViewModels
{
    [Export]
    public class View2ViewModel : NotificationObject, ITabInfoProvider
    {
        private bool toggle;

        public View2ViewModel()
        {
            this.ToggleMessageCommand = new DelegateCommand<string>(ToggleMessage);
            this.MoveMouseCommand = new DelegateCommand<MouseEventArgs>(MoveMouse);
        }

        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                RaisePropertyChanged(() => this.Message);
            }
        }

        private string messageColor;

        public string MessageColor
        {
            get { return messageColor; }
            set
            {
                messageColor = value;
                RaisePropertyChanged(() => this.MessageColor);
            }
        }

        public ICommand ToggleMessageCommand { get; set; }

        public void ToggleMessage(string message)
        {
            this.Message = message;
            toggle = !toggle;
            this.MessageColor = (toggle) ? "Green" : "Crimson";
        }

        public void ShowMessage()
        {
            this.Message = "MouseClick Event!";
        }

        public ICommand MoveMouseCommand { get; set; }

        public void MoveMouse(MouseEventArgs e)
        {
            var element = e.OriginalSource as System.Windows.IInputElement;
            var point = e.GetPosition(element);

            this.Message = string.Format("MoveMouse Event! Position: {0}x{1}", point.X, point.Y);
            this.MessageColor = "Maroon";
        }

        public void ConfirmCloseTabRequest(Action<bool> confirmationCallback)
        {
            confirmationCallback(true);
        }

        public bool ShowCloseButton
        {
            get { return true; }
        }

        public string TabHeader
        {
            get { return "Module 1 - View 2"; }
        }
    }
}

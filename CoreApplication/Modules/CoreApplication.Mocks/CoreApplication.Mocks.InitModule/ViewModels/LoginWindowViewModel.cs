using CoreApplication.Common.Security;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoreApplication.Mocks.InitModule.ViewModels
{
    [Export]
    public class LoginWindowViewModel : NotificationObject
    {
        public LoginWindowViewModel()
        {
            this.LoginCommand = new DelegateCommand<object>(Login, CanExecuteLoginCommand);
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                RaisePropertyChanged(() => this.UserName);
                LoginCommand.RaiseCanExecuteChanged();
            }
        }

        private bool? result;

        public bool? Result
        {
            get { return result; }
            set
            {
                result = value;
                RaisePropertyChanged(() => this.Result);
            }
        }

        public DelegateCommand<object> LoginCommand { get; set; }

        public void Login(object parameter)
        {
            var passwordBox = parameter as System.Windows.Controls.PasswordBox;
            string password = passwordBox.Password;

            if (!String.IsNullOrEmpty(this.UserName) && !String.IsNullOrEmpty(password))
            {
                var claims = GetClaims(this.UserName);
                NucleoIdentity identity = SecurityManager.LogIn(claims, true);
                this.Result = identity.IsAuthenticated;
            }
        }

        public bool CanExecuteLoginCommand(object parameter)
        {
            bool canExecute = (!String.IsNullOrEmpty(this.UserName));
            return canExecute;
        }

        private Dictionary<string, object> GetClaims(string userName)
        {
            Dictionary<string, object> claims = new Dictionary<string, object>();
            claims.Add(ClaimKeys.UserName, userName);
            claims.Add(ClaimKeys.FirstName, "Nombre123");
            claims.Add(ClaimKeys.FathersName, "ApellidoPaterno123");
            claims.Add(ClaimKeys.MothersName, "ApellidoMaterno123");
            claims.Add(ClaimKeys.MustChangePassword, false);
            claims.Add(ClaimKeys.Rut, "12345678-5");
            claims.Add(ClaimKeys.SessionTimeoutSeconds, 100);

            return claims;
        }
    }
}

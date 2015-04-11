using System;
using System.Windows;
using CoreApplication.Shell.Helpers;

namespace CoreApplication.Shell
{
    public partial class App : Application
    {
        AutoLogoffHelper autoLogoffHelper;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

#if (DEBUG)
            RunInDebugMode();
#else
            RunInReleaseMode();
#endif
            this.autoLogoffHelper = new AutoLogoffHelper(new AutoLogoffHelper.LogoffDelegate(Logoff));
            this.autoLogoffHelper.Start();
        }

        private void RunInDebugMode()
        {
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }

        private void RunInReleaseMode()
        {
            AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;
            try
            {
                Bootstrapper bootstrapper = new Bootstrapper();
                bootstrapper.Run();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        public void ResetSessionTimeOut()
        {
            this.autoLogoffHelper.Reset();
        }

        public void Logoff()
        {
            // TODO: enviar a página de login en vez de cerrar la app
            //Application.Current.Dispatcher.Invoke(new Action(() => this.Shutdown()));
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null)
                return;

            //HandleException Helper class with Exception Policy
            MessageBox.Show(ex.Message);
            Environment.Exit(1);
        }
    }
}

using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using CoreApplication.Common.Security;
using CoreApplication.Infrastructure;
using CoreApplication.Infrastructure.Events;
using CoreApplication.Infrastructure.Interfaces;
using CoreApplication.Infrastructure.Models;
using CoreApplication.Shell.Adapters;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.MefExtensions;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using CoreApplication.Common.ComponentModel;
using System.Configuration;
using CoreApplication.Common.ExceptionHandling;

namespace CoreApplication.Shell
{
    public class Bootstrapper : MefBootstrapper
    {
        private bool isShuttingDown;

        protected override DependencyObject CreateShell()
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            IInitModule initModule = this.Container.GetExportedValue<IInitModule>();
            initModule.LoadPrincipal();

            NucleoPrincipal principal = Thread.CurrentPrincipal as NucleoPrincipal;
            if (principal != null && principal.Identity != null && principal.Identity.IsAuthenticated)
            {
                Views.ProfesionalShell mainShell = this.Container.GetExportedValue<Views.ProfesionalShell>();
                App.Current.MainWindow = mainShell;
                mainShell.ShowActivated = true;
                mainShell.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                mainShell.Closing += ProfesionalShell_Closing;
                mainShell.Show();
                
                return mainShell;
            }
            else
            {
                Environment.Exit(0);
                return null;
            }
        }

        protected override CompositionContainer CreateContainer()
        {
            var container = base.CreateContainer();
            container.ComposeExportedValue(container);
            
            ComponentContainer.Initialize();
            container.ComposeExportedValue<IComponentContainer>(ComponentContainer.Instance);

            return container;
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(CoreApplication.Infrastructure.ShellType).Assembly));

            try
            {
                string modulesPath = ConfigurationManager.AppSettings[Defaults.ModulesPathSetting];

                if (!String.IsNullOrEmpty(modulesPath))
                {
                    DirectoryCatalog catalog = new DirectoryCatalog(modulesPath);
                    this.AggregateCatalog.Catalogs.Add(catalog);
                }
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex, Defaults.BootstrapExceptionPolicy);
            }
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            var output = ServiceLocator.Current.GetInstance<RegionAdapterMappings>();

            if (output != null)
            {
                output.RegisterMapping(typeof(Selector), ServiceLocator.Current.GetInstance<CustomSelectorRegionAdapter>());
                output.RegisterMapping(typeof(ItemsControl), ServiceLocator.Current.GetInstance<CustomItemsControlRegionAdapter>());
                output.RegisterMapping(typeof(ContentControl), ServiceLocator.Current.GetInstance<CustomContentControlRegionAdapter>());
            }

            return output;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            if (this.Shell != null)
            {
                Views.PacienteShell pacienteShell = this.Container.GetExportedValue<Views.PacienteShell>();
                pacienteShell.Owner = (Window)this.Shell;
                pacienteShell.ShowActivated = true;
                pacienteShell.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                pacienteShell.Closing += PacienteShell_Closing;
                
                //Agrega servicio de IRegionManager a shell de paciente
                RegionManager.SetRegionManager(pacienteShell, this.Container.GetExportedValue<IRegionManager>());
                RegionManager.UpdateRegions();

                IEventAggregator eventAggregator = this.Container.GetExportedValue<IEventAggregator>();
                SwitchShellEvent switchShellEvent = eventAggregator.GetEvent<SwitchShellEvent>();
                switchShellEvent.Subscribe(SwitchShell, ThreadOption.UIThread, false, (shell) => !this.isShuttingDown);
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        void ProfesionalShell_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Se utilizó System.Windows.Forms.Application.Restart() para reiniciar la aplicación
            //ya que es compatible con ClickOnce. En caso de no querer usar System.Windows.Forms.dll
            //se debe utilzar System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            System.Windows.Forms.Application.Restart();
            Application.Current.Shutdown();
            this.isShuttingDown = true;
        }

        void PacienteShell_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Application.Current.MainWindow != null)
            {
                ShellNavigationHelper shellNavigationHelper = this.Container.GetExportedValue<ShellNavigationHelper>();
                shellNavigationHelper.SwitchShell(ShellType.ProfesionalShell);

                e.Cancel = true;
            }
        }

        private void SwitchShell(SwitchShellData data)
        {
            Window shell = null;
            IEventAggregator eventAggregator = this.Container.GetExportedValue<IEventAggregator>();

            switch (data.Shell)
            {
                case Infrastructure.ShellType.ProfesionalShell:
                    shell = this.Container.GetExportedValue<Views.ProfesionalShell>();
                    break;
                case Infrastructure.ShellType.PacienteShell:
                    shell = this.Container.GetExportedValue<Views.PacienteShell>();
                    PacienteShellShowingEvent pacienteShellShowingEvent = eventAggregator.GetEvent<PacienteShellShowingEvent>();
                    pacienteShellShowingEvent.Publish(data);
                    break;
                default:
                    break;
            }
            if (shell != null)
            {
                Application app = Application.Current;
                for (int intCounter = app.Windows.Count - 1; intCounter >= 0; intCounter--)
                {
                    app.Windows[intCounter].Hide();
                }

                shell.Show();
            }
        }
    }
}

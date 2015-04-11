using System.ComponentModel.Composition;
using System.Windows;
using CoreApplication.Shell.Helpers;
using CoreApplication.Shell.ViewModels;

namespace CoreApplication.Shell.Views
{
    [Export]
    public partial class ProfesionalShell : WindowBase
    {
        [ImportingConstructor]
        public ProfesionalShell(ProfesionalShellViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;

            this.Loaded += ProfesionalShell_Loaded;
        }

        private void ProfesionalShell_Loaded(object sender, RoutedEventArgs e)
        {
            // TODO: agregar lógica de selección de tema
            ThemesHelper.SetTheme(Theme.Urgencia);
        }
    }
}

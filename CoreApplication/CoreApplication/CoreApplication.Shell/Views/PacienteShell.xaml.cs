using System.ComponentModel.Composition;
using CoreApplication.Shell.ViewModels;

namespace CoreApplication.Shell.Views
{
    [Export]
    public partial class PacienteShell : WindowBase
    {
        [ImportingConstructor]
        public PacienteShell(PacienteShellViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}

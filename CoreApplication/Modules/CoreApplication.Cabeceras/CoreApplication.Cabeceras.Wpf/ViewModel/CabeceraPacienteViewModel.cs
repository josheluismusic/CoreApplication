using CoreApplication.Common.ComponentModel;
using CoreApplication.Cabeceras.Contrato.Models;
using CoreApplication.Cabeceras.Contrato.ServiceInterfaces;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CoreApplication.Cabeceras.Wpf.ViewModel 
{
    [Export]
    public class CabeceraPacienteViewModel : INotifyPropertyChanged
    {
        private readonly IRegionManager regionManager;
        private readonly ICabeceraPacienteService cabeceraPaciente;

        public ObservableCollection<Paciente> pacientes { get; set; }
        private Paciente _paciente { get; set; }



        [ImportingConstructor]
        public CabeceraPacienteViewModel(IRegionManager regionManager, IComponentContainer componentContainer)
        {
            this.regionManager = regionManager;
            this.cabeceraPaciente = componentContainer.Resolve<ICabeceraPacienteService>();
            
            this.pacientes = new ObservableCollection<Paciente>(this.cabeceraPaciente.GetDatosPaciente());
            this._paciente = this.cabeceraPaciente.GetDatosPacientef();
        }


        public string nombrePaciente
        {
            get { return this._paciente.nombrePaciente; }
            set
            {
                if (this._paciente.nombrePaciente != value)
                {
                    this._paciente.nombrePaciente = value;
                    this.RaisePropertyChanged("nombrePaciente");
                }
            }
        }

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        private void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

    }
}

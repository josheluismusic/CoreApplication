using CoreApplication.Common.ComponentModel;
using CoreApplication.Urgencia.Contrato.Models;
using CoreApplication.Urgencia.Contrato.ServiceInterfaces;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Urgencia.Wpf.ViewModels
{
    [Export]
    public class ListadoUrgenciaViewModel : NotificationObject
    {
        private readonly IRegionManager regionManager;
        private readonly IUrgenciaService urgenciaService;

        [ImportingConstructor]
        public ListadoUrgenciaViewModel(IRegionManager regionManager, IComponentContainer componentContainer)
        {
            this.regionManager = regionManager;
            this.urgenciaService = componentContainer.Resolve<IUrgenciaService>();
            this.Pacientes = new ObservableCollection<UrgenciaModel>(this.urgenciaService.GetListadoUrgencia());
        }

        public ObservableCollection<UrgenciaModel> Pacientes { get; set; }
    }
}

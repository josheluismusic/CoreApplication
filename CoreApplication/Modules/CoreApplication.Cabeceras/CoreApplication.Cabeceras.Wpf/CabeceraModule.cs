using CoreApplication.Common.ComponentModel;
using CoreApplication.Cabeceras.Contrato.ServiceInterfaces;
using CoreApplication.Cabeceras.Mocks.Servicio.Implementation;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Cabeceras.Wpf
{
    [ModuleExport(typeof(CabeceraModule))]
    public class CabeceraModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IComponentContainer componentContainer;

        [ImportingConstructor]
        public CabeceraModule(IRegionManager regionManager, IComponentContainer componentContainer)
        {
            this.regionManager = regionManager;
            this.componentContainer = componentContainer;
        }

        public void Initialize()
        {
            componentContainer.Register<ICabeceraPacienteService,MockCabeceraPaciente>();
        }
    }
}

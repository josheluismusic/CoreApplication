using CoreApplication.Common.ComponentModel;
using CoreApplication.Urgencia.Contrato.ServiceInterfaces;
using CoreApplication.Urgencia.Mocks.ServicioMocks.Implementation;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Urgencia.Wpf
{
    [ModuleExport(typeof(UrgenciaModule))]
    public class UrgenciaModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IComponentContainer componentContainer;

        [ImportingConstructor]
        public UrgenciaModule(IRegionManager regionManager, IComponentContainer componentContainer)
        {
            this.regionManager = regionManager;
            this.componentContainer = componentContainer;
        }

        public void Initialize()
        {
            componentContainer.Register<IUrgenciaService, MockUrgenciaService>();
        }
    }
}

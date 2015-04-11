using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.BasicModule
{
    [ModuleExport(typeof(BasicModule))]
    public class BasicModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        [ImportingConstructor]
        public BasicModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        #region IModule Members

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("ProfesionalHeadRegion", typeof(Head));
            regionViewRegistry.RegisterViewWithRegion("ProfesionalMainRegion", typeof(Main));

            regionViewRegistry.RegisterViewWithRegion("PacienteHeadRegion", typeof(PacienteShellHead));
            regionViewRegistry.RegisterViewWithRegion("PacienteInfoRegion", typeof(PacienteShellInfo));
            regionViewRegistry.RegisterViewWithRegion("PacienteMainRegion", typeof(PacienteShellMain));
        }

        #endregion
    }
}

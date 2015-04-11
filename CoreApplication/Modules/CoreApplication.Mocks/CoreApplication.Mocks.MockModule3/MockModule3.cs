using System.ComponentModel.Composition;
using CoreApplication.Infrastructure;
using CoreApplication.Mocks.MockModule3.Views.Default;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Mocks.MockModule3
{
    [ModuleExport(typeof(MockModule3))]
    public class MockModule3 : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        [ImportingConstructor]
        public MockModule3(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        #region IModule Members

        public void Initialize()
        {
            this.regionViewRegistry.RegisterViewWithRegion(RegionNames.ProfesionalShellHeadRegion, typeof(ProfesionalHead));
            this.regionViewRegistry.RegisterViewWithRegion(RegionNames.ProfesionalShellMainRegion, typeof(ProfesionalMain));
            this.regionViewRegistry.RegisterViewWithRegion(RegionNames.PacienteShellHeadRegion, typeof(PacienteHead));
            this.regionViewRegistry.RegisterViewWithRegion(RegionNames.PacienteShellInfoRegion, typeof(PacienteInfo));
            this.regionViewRegistry.RegisterViewWithRegion(RegionNames.PacienteShellMainRegion, typeof(PacienteMain));
        }

        #endregion
    }
}

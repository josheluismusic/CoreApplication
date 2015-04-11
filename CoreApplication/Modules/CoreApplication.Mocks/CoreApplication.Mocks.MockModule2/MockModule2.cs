using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Mocks.MockModule2
{
    [ModuleExport(typeof(MockModule2))]
    public class MockModule2 : IModule
    {
        public void Initialize()
        {
        }
    }
}

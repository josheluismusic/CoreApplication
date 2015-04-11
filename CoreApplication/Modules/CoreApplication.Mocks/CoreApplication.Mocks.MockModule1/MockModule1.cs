using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Mocks.MockModule1
{
    [ModuleExport(typeof(MockModule1))]
    public class MockModule1 : IModule
    {
        public void Initialize()
        {
            
        }
    }
}

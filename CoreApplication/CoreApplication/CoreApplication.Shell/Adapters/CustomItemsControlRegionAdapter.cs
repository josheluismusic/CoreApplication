using System.ComponentModel.Composition;
using CoreApplication.Shell.Regions;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Shell.Adapters
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class CustomItemsControlRegionAdapter : ItemsControlRegionAdapter
    {
        [ImportingConstructor]
        public CustomItemsControlRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            : base(regionBehaviorFactory)
        {
        }

        protected override IRegion CreateRegion()
        {
            return new CustomAllActiveRegion();
        }
    }
}

using System.ComponentModel.Composition;
using CoreApplication.Shell.Regions;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Shell.Adapters
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class CustomContentControlRegionAdapter : ContentControlRegionAdapter
    {
        [ImportingConstructor]
        public CustomContentControlRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            : base(regionBehaviorFactory)
        {
        }

        protected override IRegion CreateRegion()
        {
            return new CustomSingleActiveRegion();
        }
    }
}

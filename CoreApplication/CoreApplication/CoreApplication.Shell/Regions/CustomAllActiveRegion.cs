using System;
using Microsoft.Practices.Prism.Regions;

namespace CoreApplication.Shell.Regions
{
    public class CustomAllActiveRegion : CustomRegion
    {
        public override IViewsCollection ActiveViews
        {
            get { return Views; }
        }

        public override void Deactivate(object view)
        {
            throw new InvalidOperationException("Deactivation is not possible in this type of region.");
        }
    }
}

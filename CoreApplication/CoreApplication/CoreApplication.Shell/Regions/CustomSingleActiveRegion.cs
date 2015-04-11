using System.Linq;

namespace CoreApplication.Shell.Regions
{
    public class CustomSingleActiveRegion : CustomRegion
    {
        public override void Activate(object view)
        {
            object currentActiveView = ActiveViews.FirstOrDefault();

            if (currentActiveView != null && currentActiveView != view && this.Views.Contains(currentActiveView))
            {
                base.Deactivate(currentActiveView);
            }

            base.Activate(view);
        }
    }
}

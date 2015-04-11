using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using CoreApplication.Common.Security;

namespace CoreApplication.Shell.Regions
{
    public class CustomRegion : Region
    {
        public CustomRegion()
            : base()
        {
        }

        public override IRegionManager Add(object view, string viewName, bool createRegionManagerScope)
        {
            SecurityManager.AuditAsync(1, "El usuario [{0}] está intentando acceder a la vista [{1}]",
                SecurityManager.CurrentUser.Identity.Name,
                view.ToString());
            
            // TODO: verificar autorización
            
            var rm = base.Add(view, viewName, createRegionManagerScope);
            
            SecurityManager.AuditAsync(1, "El usuario [{0}] accedió a la vista [{1}]",
                SecurityManager.CurrentUser.Identity.Name,
                view.ToString());
            
            return rm;
        }
    }
}

using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GSS.Controllers
{
    public abstract class GSSControllerBase: AbpController
    {
        protected GSSControllerBase()
        {
            LocalizationSourceName = GSSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

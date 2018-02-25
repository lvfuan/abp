using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpCoreProjrct.Controllers
{
    public abstract class AbpCoreProjrctControllerBase: AbpController
    {
        protected AbpCoreProjrctControllerBase()
        {
            LocalizationSourceName = AbpCoreProjrctConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

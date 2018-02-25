using Abp.AspNetCore.Mvc.ViewComponents;

namespace AbpCoreProjrct.Web.Views
{
    public abstract class AbpCoreProjrctViewComponent : AbpViewComponent
    {
        protected AbpCoreProjrctViewComponent()
        {
            LocalizationSourceName = AbpCoreProjrctConsts.LocalizationSourceName;
        }
    }
}

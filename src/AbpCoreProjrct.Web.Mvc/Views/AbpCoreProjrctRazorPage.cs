using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AbpCoreProjrct.Web.Views
{
    public abstract class AbpCoreProjrctRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpCoreProjrctRazorPage()
        {
            LocalizationSourceName = AbpCoreProjrctConsts.LocalizationSourceName;
        }
    }
}

using Abp.AutoMapper;
using AbpCoreProjrct.Sessions.Dto;

namespace AbpCoreProjrct.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}

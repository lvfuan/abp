using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpCoreProjrct.MultiTenancy.Dto;

namespace AbpCoreProjrct.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

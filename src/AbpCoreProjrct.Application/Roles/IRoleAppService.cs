using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpCoreProjrct.Roles.Dto;

namespace AbpCoreProjrct.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}

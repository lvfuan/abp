using System.Collections.Generic;
using AbpCoreProjrct.Roles.Dto;

namespace AbpCoreProjrct.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}

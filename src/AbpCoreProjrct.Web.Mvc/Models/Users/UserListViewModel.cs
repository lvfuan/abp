using System.Collections.Generic;
using AbpCoreProjrct.Roles.Dto;
using AbpCoreProjrct.Users.Dto;

namespace AbpCoreProjrct.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

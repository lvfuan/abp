using Abp.Authorization;
using AbpCoreProjrct.Authorization.Roles;
using AbpCoreProjrct.Authorization.Users;

namespace AbpCoreProjrct.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

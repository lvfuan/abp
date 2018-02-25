using Abp.MultiTenancy;
using AbpCoreProjrct.Authorization.Users;

namespace AbpCoreProjrct.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

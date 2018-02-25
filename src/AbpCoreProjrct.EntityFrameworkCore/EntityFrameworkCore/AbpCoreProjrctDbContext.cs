using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpCoreProjrct.Authorization.Roles;
using AbpCoreProjrct.Authorization.Users;
using AbpCoreProjrct.MultiTenancy;

namespace AbpCoreProjrct.EntityFrameworkCore
{
    public class AbpCoreProjrctDbContext : AbpZeroDbContext<Tenant, Role, User, AbpCoreProjrctDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpCoreProjrctDbContext(DbContextOptions<AbpCoreProjrctDbContext> options)
            : base(options)
        {
        }
    }
}

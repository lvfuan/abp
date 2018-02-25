using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AbpCoreProjrct.EntityFrameworkCore.Seed;

namespace AbpCoreProjrct.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpCoreProjrctCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AbpCoreProjrctEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AbpCoreProjrctDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AbpCoreProjrctDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AbpCoreProjrctDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreProjrctEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}

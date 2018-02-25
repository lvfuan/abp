using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreProjrct.Configuration;
using AbpCoreProjrct.EntityFrameworkCore;
using AbpCoreProjrct.Migrator.DependencyInjection;

namespace AbpCoreProjrct.Migrator
{
    [DependsOn(typeof(AbpCoreProjrctEntityFrameworkModule))]
    public class AbpCoreProjrctMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpCoreProjrctMigratorModule(AbpCoreProjrctEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AbpCoreProjrctMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AbpCoreProjrctConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreProjrctMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}

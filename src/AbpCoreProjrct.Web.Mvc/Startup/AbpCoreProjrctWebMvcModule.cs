using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreProjrct.Configuration;

namespace AbpCoreProjrct.Web.Startup
{
    [DependsOn(typeof(AbpCoreProjrctWebCoreModule))]
    public class AbpCoreProjrctWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpCoreProjrctWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<AbpCoreProjrctNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreProjrctWebMvcModule).GetAssembly());
        }
    }
}

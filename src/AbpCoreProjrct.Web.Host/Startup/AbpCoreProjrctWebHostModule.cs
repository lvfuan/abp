using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreProjrct.Configuration;

namespace AbpCoreProjrct.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpCoreProjrctWebCoreModule))]
    public class AbpCoreProjrctWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpCoreProjrctWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreProjrctWebHostModule).GetAssembly());
        }
    }
}

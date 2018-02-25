using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpCoreProjrct.Configuration;
using AbpCoreProjrct.Web;

namespace AbpCoreProjrct.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpCoreProjrctDbContextFactory : IDesignTimeDbContextFactory<AbpCoreProjrctDbContext>
    {
        public AbpCoreProjrctDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpCoreProjrctDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpCoreProjrctDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpCoreProjrctConsts.ConnectionStringName));

            return new AbpCoreProjrctDbContext(builder.Options);
        }
    }
}

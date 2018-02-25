using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpCoreProjrct.EntityFrameworkCore
{
    public static class AbpCoreProjrctDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpCoreProjrctDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpCoreProjrctDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

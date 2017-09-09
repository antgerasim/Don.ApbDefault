using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Don.ApbDefault.EntityFrameworkCore
{
    public static class ApbDefaultDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ApbDefaultDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ApbDefaultDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
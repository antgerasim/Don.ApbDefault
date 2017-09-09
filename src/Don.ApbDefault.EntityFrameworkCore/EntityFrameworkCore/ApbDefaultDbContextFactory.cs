using Don.ApbDefault.Configuration;
using Don.ApbDefault.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Don.ApbDefault.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ApbDefaultDbContextFactory : IDesignTimeDbContextFactory<ApbDefaultDbContext>
    {
        public ApbDefaultDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApbDefaultDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ApbDefaultDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ApbDefaultConsts.ConnectionStringName));

            return new ApbDefaultDbContext(builder.Options);
        }
    }
}
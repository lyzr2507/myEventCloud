using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using myEventCloud.Configuration;
using myEventCloud.Web;

namespace myEventCloud.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class myEventCloudDbContextFactory : IDesignTimeDbContextFactory<myEventCloudDbContext>
    {
        public myEventCloudDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<myEventCloudDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            myEventCloudDbContextConfigurer.Configure(builder, configuration.GetConnectionString(myEventCloudConsts.ConnectionStringName));

            return new myEventCloudDbContext(builder.Options);
        }
    }
}

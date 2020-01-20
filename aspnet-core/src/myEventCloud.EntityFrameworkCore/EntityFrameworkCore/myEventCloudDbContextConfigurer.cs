using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace myEventCloud.EntityFrameworkCore
{
    public static class myEventCloudDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<myEventCloudDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<myEventCloudDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

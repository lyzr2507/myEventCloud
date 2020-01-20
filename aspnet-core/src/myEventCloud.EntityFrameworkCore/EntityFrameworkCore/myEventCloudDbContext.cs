using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using myEventCloud.Authorization.Roles;
using myEventCloud.Authorization.Users;
using myEventCloud.MultiTenancy;

namespace myEventCloud.EntityFrameworkCore
{
    public class myEventCloudDbContext : AbpZeroDbContext<Tenant, Role, User, myEventCloudDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public myEventCloudDbContext(DbContextOptions<myEventCloudDbContext> options)
            : base(options)
        {
        }
    }
}

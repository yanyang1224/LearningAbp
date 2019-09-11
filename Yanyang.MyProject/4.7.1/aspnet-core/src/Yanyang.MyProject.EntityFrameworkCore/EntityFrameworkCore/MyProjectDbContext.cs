using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Yanyang.MyProject.Authorization.Roles;
using Yanyang.MyProject.Authorization.Users;
using Yanyang.MyProject.MultiTenancy;

namespace Yanyang.MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
        }
    }
}

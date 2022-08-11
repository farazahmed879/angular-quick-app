using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GSS.Authorization.Roles;
using GSS.Authorization.Users;
using GSS.MultiTenancy;

namespace GSS.EntityFrameworkCore
{
    public class GSSDbContext : AbpZeroDbContext<Tenant, Role, User, GSSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GSSDbContext(DbContextOptions<GSSDbContext> options)
            : base(options)
        {
        }
    }
}

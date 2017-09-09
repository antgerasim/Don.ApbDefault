using Abp.Zero.EntityFrameworkCore;
using Don.ApbDefault.Authorization.Roles;
using Don.ApbDefault.Authorization.Users;
using Don.ApbDefault.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Don.ApbDefault.EntityFrameworkCore
{
    public class ApbDefaultDbContext : AbpZeroDbContext<Tenant, Role, User, ApbDefaultDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public ApbDefaultDbContext(DbContextOptions<ApbDefaultDbContext> options)
            : base(options)
        {

        }
    }
}

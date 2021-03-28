using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WizeTech_Business_CRM.Authorization.Roles;
using WizeTech_Business_CRM.Authorization.Users;
using WizeTech_Business_CRM.MultiTenancy;

namespace WizeTech_Business_CRM.EntityFrameworkCore
{
    public class WizeTech_Business_CRMDbContext : AbpZeroDbContext<Tenant, Role, User, WizeTech_Business_CRMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WizeTech_Business_CRMDbContext(DbContextOptions<WizeTech_Business_CRMDbContext> options)
            : base(options)
        {
        }
    }
}

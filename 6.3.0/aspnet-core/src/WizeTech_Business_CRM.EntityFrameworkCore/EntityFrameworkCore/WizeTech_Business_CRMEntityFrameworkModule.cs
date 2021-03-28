using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using WizeTech_Business_CRM.EntityFrameworkCore.Seed;

namespace WizeTech_Business_CRM.EntityFrameworkCore
{
    [DependsOn(
        typeof(WizeTech_Business_CRMCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class WizeTech_Business_CRMEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<WizeTech_Business_CRMDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        WizeTech_Business_CRMDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        WizeTech_Business_CRMDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WizeTech_Business_CRMEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}

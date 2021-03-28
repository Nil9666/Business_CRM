using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WizeTech_Business_CRM.EntityFrameworkCore;
using WizeTech_Business_CRM.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace WizeTech_Business_CRM.Web.Tests
{
    [DependsOn(
        typeof(WizeTech_Business_CRMWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class WizeTech_Business_CRMWebTestModule : AbpModule
    {
        public WizeTech_Business_CRMWebTestModule(WizeTech_Business_CRMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WizeTech_Business_CRMWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(WizeTech_Business_CRMWebMvcModule).Assembly);
        }
    }
}
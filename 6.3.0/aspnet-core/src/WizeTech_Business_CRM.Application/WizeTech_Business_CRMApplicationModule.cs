using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WizeTech_Business_CRM.Authorization;

namespace WizeTech_Business_CRM
{
    [DependsOn(
        typeof(WizeTech_Business_CRMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WizeTech_Business_CRMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WizeTech_Business_CRMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WizeTech_Business_CRMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WizeTech_Business_CRM.Configuration;
using WizeTech_Business_CRM.EntityFrameworkCore;
using WizeTech_Business_CRM.Migrator.DependencyInjection;

namespace WizeTech_Business_CRM.Migrator
{
    [DependsOn(typeof(WizeTech_Business_CRMEntityFrameworkModule))]
    public class WizeTech_Business_CRMMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public WizeTech_Business_CRMMigratorModule(WizeTech_Business_CRMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(WizeTech_Business_CRMMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                WizeTech_Business_CRMConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WizeTech_Business_CRMMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WizeTech_Business_CRM.Configuration;

namespace WizeTech_Business_CRM.Web.Host.Startup
{
    [DependsOn(
       typeof(WizeTech_Business_CRMWebCoreModule))]
    public class WizeTech_Business_CRMWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WizeTech_Business_CRMWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WizeTech_Business_CRMWebHostModule).GetAssembly());
        }
    }
}

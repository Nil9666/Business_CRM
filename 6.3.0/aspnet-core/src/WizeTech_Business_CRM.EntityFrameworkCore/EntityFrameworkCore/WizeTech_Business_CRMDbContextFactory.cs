using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WizeTech_Business_CRM.Configuration;
using WizeTech_Business_CRM.Web;

namespace WizeTech_Business_CRM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WizeTech_Business_CRMDbContextFactory : IDesignTimeDbContextFactory<WizeTech_Business_CRMDbContext>
    {
        public WizeTech_Business_CRMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WizeTech_Business_CRMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WizeTech_Business_CRMDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WizeTech_Business_CRMConsts.ConnectionStringName));

            return new WizeTech_Business_CRMDbContext(builder.Options);
        }
    }
}

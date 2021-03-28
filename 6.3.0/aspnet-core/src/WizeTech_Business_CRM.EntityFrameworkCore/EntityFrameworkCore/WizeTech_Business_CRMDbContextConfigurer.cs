using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WizeTech_Business_CRM.EntityFrameworkCore
{
    public static class WizeTech_Business_CRMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WizeTech_Business_CRMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WizeTech_Business_CRMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

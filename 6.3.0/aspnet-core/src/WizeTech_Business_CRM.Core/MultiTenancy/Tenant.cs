using Abp.MultiTenancy;
using WizeTech_Business_CRM.Authorization.Users;

namespace WizeTech_Business_CRM.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

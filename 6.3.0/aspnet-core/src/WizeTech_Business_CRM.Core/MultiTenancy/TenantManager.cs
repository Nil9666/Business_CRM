using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using WizeTech_Business_CRM.Authorization.Users;
using WizeTech_Business_CRM.Editions;

namespace WizeTech_Business_CRM.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}

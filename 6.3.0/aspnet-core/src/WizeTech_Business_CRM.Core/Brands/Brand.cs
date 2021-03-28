using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace WizeTech_Business_CRM.Brands
{
    public class Brand : FullAuditedEntity, IPassivable, IMayHaveTenant
    {
        public string BrandName { get; set; }
        public bool IsActive { get; set; }
        public int? TenantId { get; set; }
    }
}

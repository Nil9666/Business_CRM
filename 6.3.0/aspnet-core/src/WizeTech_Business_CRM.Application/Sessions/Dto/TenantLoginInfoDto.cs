using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using WizeTech_Business_CRM.MultiTenancy;

namespace WizeTech_Business_CRM.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}

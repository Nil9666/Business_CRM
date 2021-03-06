using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Authorization;

namespace WizeTech_Business_CRM.Roles.Dto
{
    [AutoMapFrom(typeof(Permission))]
    public class PermissionDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }
    }
}

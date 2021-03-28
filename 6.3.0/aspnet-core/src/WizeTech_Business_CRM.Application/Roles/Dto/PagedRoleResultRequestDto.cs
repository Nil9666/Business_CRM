using Abp.Application.Services.Dto;

namespace WizeTech_Business_CRM.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


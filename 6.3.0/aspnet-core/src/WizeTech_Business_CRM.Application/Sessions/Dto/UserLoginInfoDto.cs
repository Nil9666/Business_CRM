using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using WizeTech_Business_CRM.Authorization.Users;

namespace WizeTech_Business_CRM.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}

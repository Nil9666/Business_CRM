using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WizeTech_Business_CRM.Roles.Dto;
using WizeTech_Business_CRM.Users.Dto;

namespace WizeTech_Business_CRM.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}

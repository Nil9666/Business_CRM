using System.Threading.Tasks;
using Abp.Application.Services;
using WizeTech_Business_CRM.Authorization.Accounts.Dto;

namespace WizeTech_Business_CRM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

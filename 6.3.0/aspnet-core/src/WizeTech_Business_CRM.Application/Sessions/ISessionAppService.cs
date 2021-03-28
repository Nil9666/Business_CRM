using System.Threading.Tasks;
using Abp.Application.Services;
using WizeTech_Business_CRM.Sessions.Dto;

namespace WizeTech_Business_CRM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

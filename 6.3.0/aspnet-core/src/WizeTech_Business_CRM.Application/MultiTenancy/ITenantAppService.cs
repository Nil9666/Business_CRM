using Abp.Application.Services;
using WizeTech_Business_CRM.MultiTenancy.Dto;

namespace WizeTech_Business_CRM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


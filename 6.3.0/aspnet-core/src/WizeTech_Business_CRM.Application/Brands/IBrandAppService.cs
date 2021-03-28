using Abp.Application.Services;
using WizeTech_Business_CRM.Brands.Dtos;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace WizeTech_Business_CRM.Brands
{
    public interface IBrandAppService : IApplicationService
    {
        GetAllBrandsOutputDto GetAll(BrandFilteredDto input);
        Task<BrandDto> CreateAsync(CreateOrEditBrandDto input);
    }
}

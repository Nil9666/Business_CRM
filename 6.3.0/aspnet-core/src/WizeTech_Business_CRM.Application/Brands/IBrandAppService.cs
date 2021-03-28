using Abp.Application.Services;
using WizeTech_Business_CRM.Brands.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WizeTech_Business_CRM.Brands
{
    public interface IBrandAppService : IApplicationService
    {
        Task<List<BrandDto>> GetAll();
        Task<BrandDto> CreateAsync(CreateOrEditBrandDto input);
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using WizeTech_Business_CRM.Brands.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Collections.Extensions;
using Abp.Linq.Extensions;
using System.Linq.Dynamic.Core;
using Abp.Extensions;

namespace WizeTech_Business_CRM.Brands
{
    public class BrandAppService : WizeTech_Business_CRMAppServiceBase, IBrandAppService
    {
        private readonly IRepository<Brand> _brandRepository;
        public BrandAppService(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }


        public async Task<BrandDto> CreateAsync(CreateOrEditBrandDto input)
        {
            try
            {
                if (input.Id > 0)
                {
                    return ObjectMapper.Map<BrandDto>(await _brandRepository.FirstOrDefaultAsync(input.Id));
                }
                else
                {
                    var State = ObjectMapper.Map<Brand>(input);

                    if (AbpSession.TenantId != null)
                    {
                        State.TenantId = (int?)AbpSession.TenantId;
                    }

                    await _brandRepository.InsertAndGetIdAsync(State);
                    return ObjectMapper.Map<BrandDto>(State);
                }

            }
            catch (Exception ex)
            {
                return new BrandDto();
            }
        }

        public GetAllBrandsOutputDto GetAll(BrandFilteredDto input)
        {
            try
            {
                 var Brands = ObjectMapper.Map<List<BrandDto>>(_brandRepository.GetAll().Where(e => e.TenantId == AbpSession.TenantId).AsQueryable()
                .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), x => x.BrandName.ToLower().Contains(input.FilterText.ToLower()))
                .OrderByDescending(e => e.CreationTime).ToList());

                return new GetAllBrandsOutputDto()
                { 
                    Items = Brands,
                    Total = Brands.Count
                };
            }
            catch (Exception ex)
            {
                return new GetAllBrandsOutputDto()
                {
                    Items = new List<BrandDto>(),
                    Total = 0
                };
            }
        }
    }
}

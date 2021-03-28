using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using WizeTech_Business_CRM.Brands.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<BrandDto>> GetAll()
        {
            var Brands = await _brandRepository.GetAllListAsync(e => e.TenantId == AbpSession.TenantId);

            try
            {
                var BrandsList = ObjectMapper.Map<List<BrandDto>>(Brands.OrderByDescending(e => e.CreationTime).ToList());

                return BrandsList;
            }
            catch (Exception ex)
            {
                return new List<BrandDto>();
            }
        }
    }
}

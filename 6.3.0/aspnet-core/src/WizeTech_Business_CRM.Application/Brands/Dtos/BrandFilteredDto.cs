using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizeTech_Business_CRM.Brands.Dtos
{
    public class BrandFilteredDto : PagedResultRequestDto
    {
        public string FilterText { get; set; }
    }
}

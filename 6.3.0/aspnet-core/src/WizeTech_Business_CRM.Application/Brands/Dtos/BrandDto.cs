using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizeTech_Business_CRM.Brands.Dtos
{
    public class BrandDto : EntityDto
    {
        public int? TenantId { get; set; }
        public string BrandName { get; set; }
        public bool IsActive { get; set; }
    }
}

using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizeTech_Business_CRM.Brands.Dtos
{
    public class CreateOrEditBrandDto: Entity
    {
        public int? TenantId { get; set; }
        public string BrandName { get; set; }
        public bool IsActive { get; set; }
    }
}

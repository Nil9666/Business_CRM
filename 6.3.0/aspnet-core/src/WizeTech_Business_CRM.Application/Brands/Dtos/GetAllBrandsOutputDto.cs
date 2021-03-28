using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizeTech_Business_CRM.Brands.Dtos
{
    public class GetAllBrandsOutputDto
    {
        public List<BrandDto> Items { get; set; }
        public int Total { get; set; }
    }
}

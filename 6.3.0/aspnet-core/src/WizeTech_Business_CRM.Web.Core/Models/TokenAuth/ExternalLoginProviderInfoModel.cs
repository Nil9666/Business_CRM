using Abp.AutoMapper;
using WizeTech_Business_CRM.Authentication.External;

namespace WizeTech_Business_CRM.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}

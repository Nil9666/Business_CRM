using System.Collections.Generic;

namespace WizeTech_Business_CRM.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}

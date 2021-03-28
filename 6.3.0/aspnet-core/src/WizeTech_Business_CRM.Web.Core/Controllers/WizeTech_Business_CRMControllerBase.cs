using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace WizeTech_Business_CRM.Controllers
{
    public abstract class WizeTech_Business_CRMControllerBase: AbpController
    {
        protected WizeTech_Business_CRMControllerBase()
        {
            LocalizationSourceName = WizeTech_Business_CRMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

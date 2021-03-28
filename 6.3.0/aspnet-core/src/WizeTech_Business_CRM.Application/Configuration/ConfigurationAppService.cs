using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WizeTech_Business_CRM.Configuration.Dto;

namespace WizeTech_Business_CRM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WizeTech_Business_CRMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

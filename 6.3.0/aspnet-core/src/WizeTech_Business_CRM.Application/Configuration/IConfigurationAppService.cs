using System.Threading.Tasks;
using WizeTech_Business_CRM.Configuration.Dto;

namespace WizeTech_Business_CRM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

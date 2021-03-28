using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace WizeTech_Business_CRM.Authorization
{
    public class WizeTech_Business_CRMAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Brands, L("Brands"));
            context.CreatePermission(PermissionNames.Pages_Brands_Edit, L("Brands_Edit"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, WizeTech_Business_CRMConsts.LocalizationSourceName);
        }
    }
}

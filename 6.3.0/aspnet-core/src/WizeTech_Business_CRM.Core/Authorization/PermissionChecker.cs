using Abp.Authorization;
using WizeTech_Business_CRM.Authorization.Roles;
using WizeTech_Business_CRM.Authorization.Users;

namespace WizeTech_Business_CRM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

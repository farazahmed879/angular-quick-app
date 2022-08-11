using Abp.Authorization;
using GSS.Authorization.Roles;
using GSS.Authorization.Users;

namespace GSS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

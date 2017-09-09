using Abp.Authorization;
using Don.ApbDefault.Authorization.Roles;
using Don.ApbDefault.Authorization.Users;

namespace Don.ApbDefault.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

using Abp.Authorization;
using Yanyang.MyProject.Authorization.Roles;
using Yanyang.MyProject.Authorization.Users;

namespace Yanyang.MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

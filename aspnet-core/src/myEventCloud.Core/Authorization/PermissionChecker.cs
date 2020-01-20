using Abp.Authorization;
using myEventCloud.Authorization.Roles;
using myEventCloud.Authorization.Users;

namespace myEventCloud.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

using Abp.Authorization;
using PxAbp.Authorization.Roles;
using PxAbp.MultiTenancy;
using PxAbp.Users;

namespace PxAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

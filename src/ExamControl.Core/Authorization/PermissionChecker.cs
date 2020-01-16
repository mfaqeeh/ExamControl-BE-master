using Abp.Authorization;
using ExamControl.Authorization.Roles;
using ExamControl.Authorization.Users;

namespace ExamControl.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

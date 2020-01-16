using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ExamControl.Controllers
{
    public abstract class ExamControlControllerBase: AbpController
    {
        protected ExamControlControllerBase()
        {
            LocalizationSourceName = ExamControlConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

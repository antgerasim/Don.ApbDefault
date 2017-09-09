using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Don.ApbDefault.Controllers
{
    public abstract class ApbDefaultControllerBase: AbpController
    {
        protected ApbDefaultControllerBase()
        {
            LocalizationSourceName = ApbDefaultConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
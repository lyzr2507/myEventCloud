using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace myEventCloud.Controllers
{
    public abstract class myEventCloudControllerBase: AbpController
    {
        protected myEventCloudControllerBase()
        {
            LocalizationSourceName = myEventCloudConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

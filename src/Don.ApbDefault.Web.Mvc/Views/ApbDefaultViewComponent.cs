using Abp.AspNetCore.Mvc.ViewComponents;

namespace Don.ApbDefault.Web.Views
{
    public abstract class ApbDefaultViewComponent : AbpViewComponent
    {
        protected ApbDefaultViewComponent()
        {
            LocalizationSourceName = ApbDefaultConsts.LocalizationSourceName;
        }
    }
}
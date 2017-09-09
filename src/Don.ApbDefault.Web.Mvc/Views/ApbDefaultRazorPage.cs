using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Don.ApbDefault.Web.Views
{
    public abstract class ApbDefaultRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ApbDefaultRazorPage()
        {
            LocalizationSourceName = ApbDefaultConsts.LocalizationSourceName;
        }
    }
}

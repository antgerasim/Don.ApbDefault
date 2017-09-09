using System.Threading.Tasks;
using Abp.AutoMapper;
using Don.ApbDefault.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace Don.ApbDefault.Web.Views.Shared.Components.TenantChange
{
    public class TenantChangeViewComponent : ApbDefaultViewComponent
    {
        private readonly ISessionAppService _sessionAppService;

        public TenantChangeViewComponent(ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionAppService.GetCurrentLoginInformations();
            var model = loginInfo.MapTo<TenantChangeViewModel>();
            return View(model);
        }
    }
}

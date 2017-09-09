using System.Linq;
using System.Threading.Tasks;
using Abp.Configuration;
using Don.ApbDefault.Configuration;
using Don.ApbDefault.Configuration.Ui;
using Microsoft.AspNetCore.Mvc;

namespace Don.ApbDefault.Web.Views.Shared.Components.RightSideBar
{
    public class RightSideBarViewComponent : ApbDefaultViewComponent
    {
        private readonly ISettingManager _settingManager;

        public RightSideBarViewComponent(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var themeName = await _settingManager.GetSettingValueAsync(AppSettingNames.UiTheme);

            var viewModel = new RightSideBarViewModel
            {
                CurrentTheme = UiThemes.All.FirstOrDefault(t => t.CssClass == themeName)
            };

            return View(viewModel);
        }
    }
}

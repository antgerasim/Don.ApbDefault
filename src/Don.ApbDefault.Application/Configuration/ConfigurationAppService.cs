using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Don.ApbDefault.Configuration.Dto;

namespace Don.ApbDefault.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ApbDefaultAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using Don.ApbDefault.Configuration.Dto;

namespace Don.ApbDefault.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
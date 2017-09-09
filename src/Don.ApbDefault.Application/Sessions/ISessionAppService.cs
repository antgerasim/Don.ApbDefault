using System.Threading.Tasks;
using Abp.Application.Services;
using Don.ApbDefault.Sessions.Dto;

namespace Don.ApbDefault.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

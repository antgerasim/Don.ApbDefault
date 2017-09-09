using System.Threading.Tasks;
using Abp.Application.Services;
using Don.ApbDefault.Authorization.Accounts.Dto;

namespace Don.ApbDefault.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.ApbDefault.Roles.Dto;

namespace Don.ApbDefault.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}

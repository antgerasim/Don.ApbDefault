using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.ApbDefault.Roles.Dto;
using Don.ApbDefault.Users.Dto;

namespace Don.ApbDefault.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
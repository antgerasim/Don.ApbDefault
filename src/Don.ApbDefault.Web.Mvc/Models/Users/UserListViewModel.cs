using System.Collections.Generic;
using Don.ApbDefault.Roles.Dto;
using Don.ApbDefault.Users.Dto;

namespace Don.ApbDefault.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
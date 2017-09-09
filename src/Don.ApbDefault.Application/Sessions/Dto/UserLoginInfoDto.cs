using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Don.ApbDefault.Authorization.Users;
using Don.ApbDefault.Users;

namespace Don.ApbDefault.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}

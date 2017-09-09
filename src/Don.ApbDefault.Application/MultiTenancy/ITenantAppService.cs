using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.ApbDefault.MultiTenancy.Dto;

namespace Don.ApbDefault.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

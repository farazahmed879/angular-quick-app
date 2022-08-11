using Abp.Application.Services;
using GSS.MultiTenancy.Dto;

namespace GSS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


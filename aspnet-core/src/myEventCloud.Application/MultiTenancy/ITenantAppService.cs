using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myEventCloud.MultiTenancy.Dto;

namespace myEventCloud.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


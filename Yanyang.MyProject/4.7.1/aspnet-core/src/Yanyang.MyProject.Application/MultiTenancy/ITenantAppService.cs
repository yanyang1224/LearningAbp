using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Yanyang.MyProject.MultiTenancy.Dto;

namespace Yanyang.MyProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


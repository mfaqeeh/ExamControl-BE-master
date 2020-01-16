using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ExamControl.MultiTenancy.Dto;

namespace ExamControl.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


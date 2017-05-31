using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PxAbp.MultiTenancy.Dto;

namespace PxAbp.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using PxAbp.Roles.Dto;

namespace PxAbp.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}

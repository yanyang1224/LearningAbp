using System.Threading.Tasks;
using Abp.Application.Services;
using Yanyang.MyProject.Authorization.Accounts.Dto;

namespace Yanyang.MyProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

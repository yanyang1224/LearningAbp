using System.Threading.Tasks;
using Abp.Application.Services;
using Yanyang.MyProject.Sessions.Dto;

namespace Yanyang.MyProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

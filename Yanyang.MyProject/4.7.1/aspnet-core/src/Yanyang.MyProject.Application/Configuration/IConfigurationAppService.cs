using System.Threading.Tasks;
using Yanyang.MyProject.Configuration.Dto;

namespace Yanyang.MyProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

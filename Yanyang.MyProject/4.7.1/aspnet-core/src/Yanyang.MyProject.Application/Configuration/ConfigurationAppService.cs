using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Yanyang.MyProject.Configuration.Dto;

namespace Yanyang.MyProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

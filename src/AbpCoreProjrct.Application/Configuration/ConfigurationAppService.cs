using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpCoreProjrct.Configuration.Dto;

namespace AbpCoreProjrct.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpCoreProjrctAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

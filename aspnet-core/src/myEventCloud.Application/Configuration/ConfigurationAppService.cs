using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using myEventCloud.Configuration.Dto;

namespace myEventCloud.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : myEventCloudAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

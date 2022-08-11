using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GSS.Configuration.Dto;

namespace GSS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GSSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

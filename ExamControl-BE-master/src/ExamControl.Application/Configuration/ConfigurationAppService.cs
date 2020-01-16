using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ExamControl.Configuration.Dto;

namespace ExamControl.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ExamControlAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

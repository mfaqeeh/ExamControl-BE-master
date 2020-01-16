using System.Threading.Tasks;
using ExamControl.Configuration.Dto;

namespace ExamControl.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

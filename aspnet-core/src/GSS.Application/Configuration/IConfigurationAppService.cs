using System.Threading.Tasks;
using GSS.Configuration.Dto;

namespace GSS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

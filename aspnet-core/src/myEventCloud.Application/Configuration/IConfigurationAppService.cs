using System.Threading.Tasks;
using myEventCloud.Configuration.Dto;

namespace myEventCloud.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

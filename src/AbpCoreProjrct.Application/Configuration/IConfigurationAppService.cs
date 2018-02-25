using System.Threading.Tasks;
using AbpCoreProjrct.Configuration.Dto;

namespace AbpCoreProjrct.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

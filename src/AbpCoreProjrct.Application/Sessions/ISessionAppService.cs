using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreProjrct.Sessions.Dto;

namespace AbpCoreProjrct.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

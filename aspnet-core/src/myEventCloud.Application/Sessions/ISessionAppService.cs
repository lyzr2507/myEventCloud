using System.Threading.Tasks;
using Abp.Application.Services;
using myEventCloud.Sessions.Dto;

namespace myEventCloud.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

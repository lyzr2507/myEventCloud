using System.Threading.Tasks;
using Abp.Application.Services;
using myEventCloud.Authorization.Accounts.Dto;

namespace myEventCloud.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

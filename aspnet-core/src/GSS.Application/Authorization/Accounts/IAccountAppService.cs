using System.Threading.Tasks;
using Abp.Application.Services;
using GSS.Authorization.Accounts.Dto;

namespace GSS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

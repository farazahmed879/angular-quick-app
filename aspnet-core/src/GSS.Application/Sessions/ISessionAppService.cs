using System.Threading.Tasks;
using Abp.Application.Services;
using GSS.Sessions.Dto;

namespace GSS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

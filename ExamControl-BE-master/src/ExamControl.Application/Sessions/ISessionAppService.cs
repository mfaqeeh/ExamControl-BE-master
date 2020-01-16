using System.Threading.Tasks;
using Abp.Application.Services;
using ExamControl.Sessions.Dto;

namespace ExamControl.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

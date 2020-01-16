using System.Threading.Tasks;
using Abp.Application.Services;
using ExamControl.Authorization.Accounts.Dto;

namespace ExamControl.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

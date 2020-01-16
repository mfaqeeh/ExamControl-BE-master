using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public class CancelReasonManager : IDomainService ,ICancelReasonManager
    {
        private readonly IRepository<CancelReason> _repositoryCancelReason;

        public CancelReasonManager(IRepository<CancelReason> repositoryCancelReason)
        {
            _repositoryCancelReason = repositoryCancelReason;
        }

        public async Task<CancelReason> Create(CancelReason entity)
        {
            var reason = _repositoryCancelReason.FirstOrDefault(x => x.Id == entity.Id);

            if (reason != null)
            {
                throw new Abp.UI.UserFriendlyException("Cancel Reason Already exist");
            }

            else
            {
                return await _repositoryCancelReason.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var reason = _repositoryCancelReason.FirstOrDefault(x => x.Id == id);

            if (reason == null)
            {
                throw new UserFriendlyException("No Cancel Reason Found");
            }

            else
            {
                _repositoryCancelReason.Delete(reason);
            }
        }

        public IEnumerable<CancelReason> GetCancelReason()
        {
            return _repositoryCancelReason.GetAllIncluding(x => x.Id);
        }

        public CancelReason GetCancelReasonById(int id)
        {
            return _repositoryCancelReason.Get(id);
        }

        public void Update(CancelReason entity)
        {
            _repositoryCancelReason.Update(entity);
        }
    }
}

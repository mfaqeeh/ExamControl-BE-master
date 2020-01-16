using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public class CrnManager : IDomainService,ICrnManager
    {
        private readonly IRepository<CRN> _repositoryCRN;
        public CrnManager(IRepository<CRN> repositoryCRN)
        {
            _repositoryCRN = repositoryCRN;
        }

        public async Task<CRN> Create(CRN entity)
        {
            var crn = _repositoryCRN.FirstOrDefault(x => x.Id == entity.Id);

            if (crn != null)
            {
                throw new Abp.UI.UserFriendlyException("CRN Already exist");
            }

            else
            {
                return await _repositoryCRN.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var crn = _repositoryCRN.FirstOrDefault(x => x.Id == id);

            if (crn == null)
            {
                throw new UserFriendlyException("No CRN Found");
            }

            else
            {
                _repositoryCRN.Delete(crn);
            }
        }

        public IEnumerable<CRN> GetCrn()
        {
            return _repositoryCRN.GetAllIncluding(x => x.Id);
        }

        public CRN GetCrnById(int id)
        {
            return _repositoryCRN.Get(id);
        }

        public void Update(CRN entity)
        {
            _repositoryCRN.Update(entity);
        }
    }
}

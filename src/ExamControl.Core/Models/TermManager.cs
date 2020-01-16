using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public class TermManager : IDomainService , ITermManager
    {
        private readonly IRepository<Term> _repositoryTerm;
        public TermManager(IRepository<Term> repositoryTerm)
        {
            _repositoryTerm = repositoryTerm;
        }

        public async Task<Term> Create(Term entity)
        {
            var Term = _repositoryTerm.FirstOrDefault(x => x.Id == entity.Id);

            if (Term != null)
            {
                throw new UserFriendlyException("Term Already exist");
            }

            else
            {
                return await _repositoryTerm.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var Term = _repositoryTerm.FirstOrDefault(x => x.Id == id);

            if (Term == null)
            {
                throw new UserFriendlyException("Term Booking Found");
            }

            else
            {
                _repositoryTerm.Delete(Term);
            }
        }

        public Term GetTermById(int id)
        {
            return _repositoryTerm.Get(id);
        }

        public IEnumerable<Term> GetTerms()
        {
            return _repositoryTerm.GetAllIncluding(x => x.Id);
        }

        public void Update(Term entity)
        {
            _repositoryTerm.Update(entity);
        }
    }
}

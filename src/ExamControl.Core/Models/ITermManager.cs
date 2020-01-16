using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public interface ITermManager : IDomainService
    {
        IEnumerable<Term> GetTerms();
        Term GetTermById(int id);
        Task<Term> Create(Term entity);
        void Update(Term entity);
        void Delete(int id);
    }
}

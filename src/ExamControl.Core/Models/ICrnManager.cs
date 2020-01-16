using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public interface ICrnManager : IDomainService
    {
        IEnumerable<CRN> GetCrn();
        CRN GetCrnById(int id);
        Task<CRN> Create(CRN entity);
        void Update(CRN entity);
        void Delete(int id);
    }
}

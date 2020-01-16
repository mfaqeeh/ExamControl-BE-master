using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public interface ICancelReasonManager : IDomainService
    {
        IEnumerable<CancelReason> GetCancelReason();
        CancelReason GetCancelReasonById(int id);
        Task<CancelReason> Create(CancelReason entity);
        void Update(CancelReason entity);
        void Delete(int id);
    }
}

using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public interface ISessionTypeManager : IDomainService
    {
        IEnumerable<SessionType> GetSessionTypes();
        SessionType GetSessionTypeById(int id);
        Task<SessionType> Create(SessionType entity);
        void Update(SessionType entity);
        void Delete(int id);
    }
}

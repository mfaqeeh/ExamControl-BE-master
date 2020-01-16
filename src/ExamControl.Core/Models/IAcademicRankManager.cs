using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    interface IAcademicRankManager : IDomainService
    {
        IEnumerable<AcademicRank> GetAcademicRank();
        AcademicRank GetAcademicRankById(int id);
        Task<AcademicRank> Create(AcademicRank entity);
        void Update(AcademicRank entity);
        void Delete(int id);
    }
}

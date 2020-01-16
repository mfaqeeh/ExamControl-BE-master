using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public interface IMemberManager : IDomainService
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberById(int id);
        Task<Member> Create(Member entity);
        void Update(Member entity);
        void Delete(int id);
    }
}

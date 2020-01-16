using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public interface IMemberTypeManager : IDomainService
    {
        IEnumerable<MemberType> GetMemberTypes();
        MemberType GetMemberTypeById(int id);
        Task<MemberType> Create(MemberType entity);
        void Update(MemberType entity);
        void Delete(int id);
    }
}

using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public class MemberManager : IDomainService , IMemberManager
    {
        private readonly IRepository<Member> _repositoryMember;
        public MemberManager(IRepository<Member> repositoryMemeber)
        {
            _repositoryMember = repositoryMemeber;
        }

        public async Task<Member> Create(Member entity)
        {
            var member = _repositoryMember.FirstOrDefault(x => x.Id == entity.Id);

            if (member != null)
            {
                throw new UserFriendlyException("Member Already exist");
            }

            else
            {
                return await _repositoryMember.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var member = _repositoryMember.FirstOrDefault(x => x.Id == id);

            if (member == null)
            {
                throw new UserFriendlyException("No Member Found");
            }

            else
            {
                _repositoryMember.Delete(member);
            }
        }

        public Member GetMemberById(int id)
        {
            return _repositoryMember.Get(id);
        }

        public IEnumerable<Member> GetMembers()
        {
            return _repositoryMember.GetAllIncluding(x => x.Id);
        }

        public void Update(Member entity)
        {
            _repositoryMember.Update(entity);
        }
    }
}

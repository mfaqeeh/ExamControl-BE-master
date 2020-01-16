using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public class MemberTypeManager : IDomainService , IMemberTypeManager
    {
        private readonly IRepository<MemberType> _repositoryMemberType;
        public MemberTypeManager(IRepository<MemberType> repositoryMemberType)
        {
            _repositoryMemberType = repositoryMemberType;
        }

        public async  Task<MemberType> Create(MemberType entity)
        {
            var MemberType = _repositoryMemberType.FirstOrDefault(x => x.Id == entity.Id);

            if (MemberType != null)
            {
                throw new UserFriendlyException("Member Type Already exist");
            }

            else
            {
                return await _repositoryMemberType.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var MemberType = _repositoryMemberType.FirstOrDefault(x => x.Id == id);

            if (MemberType == null)
            {
                throw new UserFriendlyException("No Member Type Found");
            }

            else
            {
                _repositoryMemberType.Delete(MemberType);
            }
        }

        public MemberType GetMemberTypeById(int id)
        {
            return _repositoryMemberType.Get(id);
        }

        public IEnumerable<MemberType> GetMemberTypes()
        {
            return _repositoryMemberType.GetAllIncluding(x => x.Id);
        }

        public void Update(MemberType entity)
        {
            _repositoryMemberType.Update(entity);
        }
    }
}

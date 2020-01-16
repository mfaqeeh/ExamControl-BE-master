using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public class CollegeManager : IDomainService,ICollegeManager
    {
        private readonly IRepository<College> _repositoryCollege;
        public CollegeManager(IRepository<College> repositoryCollege)
        {
            _repositoryCollege = repositoryCollege;
        }

        public async Task<College> Create(College entity)
        {
            var college = _repositoryCollege.FirstOrDefault(x => x.Id == entity.Id);

            if (college != null)
            {
                throw new UserFriendlyException("College Already exist");
            }

            else
            {
                return await _repositoryCollege.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var college = _repositoryCollege.FirstOrDefault(x => x.Id == id);

            if (college == null)
            {
                throw new UserFriendlyException("No College Found");
            }

            else
            {
                _repositoryCollege.Delete(college);
            }
        }

        public IEnumerable<College> GetCollege()
        {
            return _repositoryCollege.GetAllIncluding(x => x.Id);
        }

        public College GetCollegeById(int id)
        {
            return _repositoryCollege.Get(id);
        }

        public void Update(College entity)
        {
            _repositoryCollege.Update(entity);
        }
    }
}

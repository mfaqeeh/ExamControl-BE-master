using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public interface ICollegeManager :IDomainService
    {
        IEnumerable<College> GetCollege();
        College GetCollegeById(int id);
        Task<College> Create(College entity);
        void Update(College entity);
        void Delete(int id);
    }
}

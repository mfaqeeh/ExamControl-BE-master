using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public class AcademicRankManager : DomainService, IAcademicRankManager
    {
        private readonly IRepository<AcademicRank> _repositoryAcademicRank;
        public AcademicRankManager(IRepository<AcademicRank> repositoryAcademicRank)
        {

            _repositoryAcademicRank = repositoryAcademicRank;
        }

        public async Task<AcademicRank> Create(AcademicRank entity)
        {
            var rank = _repositoryAcademicRank.FirstOrDefault(x => x.Id == entity.Id);

            if (rank != null)
            {
                throw new UserFriendlyException("Academic Rank Already exist");
            }

            else
            {
                return await _repositoryAcademicRank.InsertAsync(entity);

            }
           
        }

        public void Delete(int id)
        {
            var rank = _repositoryAcademicRank.FirstOrDefault(x => x.Id == id);

            if (rank == null)
            {
                throw new UserFriendlyException("No Academic Rank Found");
            }

            else
            {
                _repositoryAcademicRank.Delete(rank);
            }
        }

        public IEnumerable<AcademicRank> GetAcademicRank()
        {
            return _repositoryAcademicRank.GetAllIncluding(x => x.Id);
        }

        public AcademicRank GetAcademicRankById(int id)
        {
            return _repositoryAcademicRank.Get(id);
        }

        public void Update(AcademicRank entity)
        {
            _repositoryAcademicRank.Update(entity);
        }
    }
}

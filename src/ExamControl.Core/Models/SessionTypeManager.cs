using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public class SessionTypeManager : IDomainService , ISessionTypeManager
    {
        private readonly IRepository<SessionType> _repositorySessionType;
        public SessionTypeManager(IRepository<SessionType> repositorySessionType)
        {
            _repositorySessionType = repositorySessionType;
        }

        public async Task<SessionType> Create(SessionType entity)
        {
            var SessionType = _repositorySessionType.FirstOrDefault(x => x.Id == entity.Id);

            if (SessionType != null)
            {
                throw new UserFriendlyException("Session Type Already exist");
            }

            else
            {
                return await _repositorySessionType.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var SessionType = _repositorySessionType.FirstOrDefault(x => x.Id == id);

            if (SessionType == null)
            {
                throw new UserFriendlyException("No Session Type Found");
            }

            else
            {
                _repositorySessionType.Delete(SessionType);
            }
        }

        public SessionType GetSessionTypeById(int id)
        {
            return _repositorySessionType.Get(id);
        }

        public IEnumerable<SessionType> GetSessionTypes()
        {
            return _repositorySessionType.GetAllIncluding(x => x.Id);
        }

        public void Update(SessionType entity)
        {
            _repositorySessionType.Update(entity);
        }
    }
}

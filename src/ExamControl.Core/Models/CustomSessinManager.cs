using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public class CustomSessinManager : IDomainService , ICustomSessinManager
    {
        private readonly IRepository<CustomSessin> _repositoryCustomSessin;
        public CustomSessinManager(IRepository<CustomSessin> repositoryCustomSessin)
        {
            _repositoryCustomSessin = repositoryCustomSessin;
        }

        public async Task<CustomSessin> Create(CustomSessin entity)
        {
            var Sessin = _repositoryCustomSessin.FirstOrDefault(x => x.Id == entity.Id);

            if (Sessin != null)
            {
                throw new UserFriendlyException("Custom Session Already exist");
            }

            else
            {
                return await _repositoryCustomSessin.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var session = _repositoryCustomSessin.FirstOrDefault(x => x.Id == id);

            if (session == null)
            {
                throw new UserFriendlyException("No Custom session Found");
            }

            else
            {
                _repositoryCustomSessin.Delete(session);
            }
        }

        public IEnumerable<CustomSessin> GetCustomSessin()
        {
            return _repositoryCustomSessin.GetAllIncluding(x => x.Id);
        }

        public CustomSessin GetCustomSessinById(int id)
        {
            return _repositoryCustomSessin.Get(id);
        }

        public void Update(CustomSessin entity)
        {
            _repositoryCustomSessin.Update(entity);
        }
    }
}

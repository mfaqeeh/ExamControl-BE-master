using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public class ObserveSettingManager : IDomainService  , IObserveSettingManager
    {
        private readonly IRepository<ObserveSetting> _repositoryObserveSetting;
        public ObserveSettingManager(IRepository<ObserveSetting> repositoryObserveSetting)
        {
            _repositoryObserveSetting = repositoryObserveSetting;
        }

        public async Task<ObserveSetting> Create(ObserveSetting entity)
        {
            var ObserveSetting = _repositoryObserveSetting.FirstOrDefault(x => x.Id == entity.Id);

            if (ObserveSetting != null)
            {
                throw new UserFriendlyException("Observe Setting Already exist");
            }

            else
            {
                return await _repositoryObserveSetting.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var ObserveSetting = _repositoryObserveSetting.FirstOrDefault(x => x.Id == id);

            if (ObserveSetting == null)
            {
                throw new UserFriendlyException("No Observe Setting Found");
            }

            else
            {
                _repositoryObserveSetting.Delete(ObserveSetting);
            }
        }

        public ObserveSetting GetObserveSettingById(int id)
        {
            return _repositoryObserveSetting.Get(id);
        }

        public IEnumerable<ObserveSetting> GetObserveSettings()
        {
            return _repositoryObserveSetting.GetAllIncluding(x => x.Id);
        }

        public void Update(ObserveSetting entity)
        {
            _repositoryObserveSetting.Update(entity);
        }
    }
}

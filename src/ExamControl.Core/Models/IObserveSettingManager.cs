using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public interface IObserveSettingManager : IDomainService
    {
        IEnumerable<ObserveSetting> GetObserveSettings();
        ObserveSetting GetObserveSettingById(int id);
        Task<ObserveSetting> Create(ObserveSetting entity);
        void Update(ObserveSetting entity);
        void Delete(int id);
    }
}

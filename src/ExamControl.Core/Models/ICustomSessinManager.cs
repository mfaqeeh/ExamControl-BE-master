using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public interface ICustomSessinManager : IDomainService
    {
        IEnumerable<CustomSessin> GetCustomSessin();
        CustomSessin GetCustomSessinById(int id);
        Task<CustomSessin> Create(CustomSessin entity);
        void Update(CustomSessin entity);
        void Delete(int id);
    }
}

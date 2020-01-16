using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public interface IBookingManager:IDomainService
    {
        IEnumerable<Booking> GetBookings();
        Booking GetBookingById(int id);
        Task<Booking> Create(Booking entity);
        void Update(Booking entity);
        void Delete(int id);
    }
}

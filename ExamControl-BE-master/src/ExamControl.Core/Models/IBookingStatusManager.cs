using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
    public interface IBookingStatusManager : IDomainService
    {
        IEnumerable<BookingStatus> GetBookingStatus();
        BookingStatus GetBookingStatusById(int id);
        Task<BookingStatus> Create(BookingStatus entity);
        void Update(BookingStatus entity);
        void Delete(int id);
    }
}

using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public class BookingManager :DomainService,IBookingManager
    {
        private readonly IRepository<Booking> _repositoryBooking;
        public BookingManager(IRepository<Booking> repositoryBooking)
        {
            _repositoryBooking = repositoryBooking;
        }

        public async Task<Booking> Create(Booking entity)
        {
            var book = _repositoryBooking.FirstOrDefault(x=>x.Id == entity.Id);

            if(book != null)
            {
                throw new UserFriendlyException("Booking Already exist");
            }

            else
            {
                return await _repositoryBooking.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var book = _repositoryBooking.FirstOrDefault(x=>x.Id == id);

            if(book == null)
            {
                throw new UserFriendlyException("No Booking Found");
            }

            else
            {
                _repositoryBooking.Delete(book);
            }
        }

        public IEnumerable<Booking> GetBookings()
        {
            return _repositoryBooking.GetAllIncluding(x=> x.Id);
        }

        public Booking GetBookingById(int id)
        {
            return _repositoryBooking.Get(id);
        }

        public void Update(Booking entity)
        {
            _repositoryBooking.Update(entity);
        }
    }
}

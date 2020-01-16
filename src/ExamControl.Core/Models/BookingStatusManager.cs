using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamControl.Models
{
   public class BookingStatusManager : DomainService, IBookingStatusManager
    {
        private readonly IRepository<BookingStatus> _repositoryBookingStatus;
        public BookingStatusManager(IRepository<BookingStatus> repositoryBookingStatus)
        {
            _repositoryBookingStatus = repositoryBookingStatus;
        }

        public async Task<BookingStatus> Create(BookingStatus entity)
        {
            var bookstatus = _repositoryBookingStatus.FirstOrDefault(x => x.Id == entity.Id);

            if (bookstatus != null)
            {
                throw new UserFriendlyException("booking status Already exist");
            }

            else
            {
                return await _repositoryBookingStatus.InsertAsync(entity);

            }
        }

        public void Delete(int id)
        {
            var bookstatus = _repositoryBookingStatus.FirstOrDefault(x => x.Id == id);

            if (bookstatus == null)
            {
                throw new UserFriendlyException("No booking status Found");
            }

            else
            {
                _repositoryBookingStatus.Delete(bookstatus);
            }
        }


        public void Update(BookingStatus entity)
        {
            _repositoryBookingStatus.Update(entity);
        }

        public IEnumerable<BookingStatus> GetBookingStatus()
        {
            return _repositoryBookingStatus.GetAllIncluding(x => x.Id);
        }

        public BookingStatus GetBookingStatusById(int id)
        {
            return _repositoryBookingStatus.Get(id);
        }
    }
}

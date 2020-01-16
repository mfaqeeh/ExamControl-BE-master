using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamControl.Models
{
   public class BookingStatus: FullAuditedEntity
    {
        public BookingStatus()
        {
            Bookings = new Collection<Booking>();
        }
        [Required]
       
        [StringLength(maximumLength: 20, ErrorMessage = "Max Lengh=20")]
        public string BookingDesc { get; set; }
        public ICollection<Booking> Bookings { get; set; }

    }
}

using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamControl.Models
{
    public class CancelReason: FullAuditedEntity
    {
        public CancelReason()
        {
            Bookings = new Collection<Booking>();
        }
        [Required]
        public string ReasonDesc { get; set; }
        public ICollection<Booking> Bookings { get; set; }

    }
}

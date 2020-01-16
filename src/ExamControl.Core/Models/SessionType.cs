using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamControl.Models
{
    public class SessionType: FullAuditedEntity
    {
        [Required]

        [StringLength(maximumLength: 20, ErrorMessage = "Max Lengh=20")]
        public string SessionDesc { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}

using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamControl.Models
{
    public class MemberType: FullAuditedEntity
    {
        [Required]

        [StringLength(maximumLength: 20, ErrorMessage = "Max Lengh=20")]
        public string BookingDesc { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}

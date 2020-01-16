using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamControl.Models
{
    public class Member: FullAuditedEntity
    {
        public Member()
        {
            Bookings = new Collection<Booking>();
            AppBookings = new Collection<Booking>();
            CustomSessins = new Collection<CustomSessin>();


        }
        [Required]

        [StringLength(maximumLength: 64, ErrorMessage = "Max Lengh=64")]
        public string MemberName { get; set; }
        [Required]
        [ForeignKey("AcademicRank")]

        public int MemberRankId { get; set; }

        [Required]
        [ForeignKey("College")]
        public int CollegeId { get; set; }

        [Required]
        [ForeignKey("MemberType")]
        public int MemberTypeId { get; set; }

        public virtual AcademicRank MemberRank { get; set; }
        public virtual College College { get; set; }
        public virtual MemberType MemberType { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Booking> AppBookings { get; set; }
        public ICollection<CustomSessin> CustomSessins { get; set; }
    }
}

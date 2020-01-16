using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamControl.Models
{
    public class Booking:FullAuditedEntity
    {

        public DateTime BookingDate { get; set; }

        public bool ApprovedStatus { get; set; }

        public DateTime ApprovedDate { get; set; }

       
        [ForeignKey("Member")]
        public int MemberId { get; set; }

        [ForeignKey("AppMember")]
        public int ApprovedBy { get; set; }

        [ForeignKey("BookingStatus")]
        public int BookingStatusId { get; set; }

        [ForeignKey("Term")]
        public int TermId { get; set; }

        [ForeignKey("CancelReason")]
        public int CancelReasonId { get; set; }

        [InverseProperty("Bookings")]
        public virtual Member Member { get; set; }

        [InverseProperty("AppBookings")]
        public virtual Member AppMember { get; set; }

        public virtual BookingStatus BookingStatus { get; set; }
        public virtual CancelReason Cancelreason { get; set; }
        public virtual Term Term { get; set; }


    }
}

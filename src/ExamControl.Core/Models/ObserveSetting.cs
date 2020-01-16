using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamControl.Models
{
    public class ObserveSetting: FullAuditedEntity
    {

        public DateTime ReservationStart{ get; set; }
        public DateTime ReservationEnd { get; set; }
        public int NoSessions { get; set; }

        [ForeignKey("College")]
        public int CollegeId { get; set; }

        [ForeignKey("AcademicRank")]
        public int AcademicRankId { get; set; }

        [ForeignKey("Term")]
        public int TermId { get; set; }
        public virtual AcademicRank MemberRank { get; set; }
        public virtual College College { get; set; }
        public virtual Term Term { get; set; }


    }
}

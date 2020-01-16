using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamControl.Models
{
    public class CustomSessin: FullAuditedEntity

    {
        
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public int NoSessions { get; set; }
        public virtual Member Member { get; set; }



    }
}

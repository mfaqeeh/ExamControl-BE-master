using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamControl.Models
{
    public class College: FullAuditedEntity
    {
        public College()
        {
            Members = new Collection<Member>();
            
        }
        [Required]

        [StringLength(maximumLength: 64, ErrorMessage = "Max Lengh=64")]
        public string CollegeName { get; set; }
        public ICollection<Member> Members { get; set; }
       
      
    }
}

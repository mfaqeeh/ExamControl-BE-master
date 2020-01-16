using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamControl.Models
{
    public class AcademicRank : FullAuditedEntity
    {

        public AcademicRank()
        {
            Settings = new Collection<ObserveSetting>();
            Members = new Collection<Member>();


        }
        [Required]

        [StringLength(maximumLength: 20, ErrorMessage = "Max Lengh=20")]
        public string RankDesc { get; set; }
        public ICollection<ObserveSetting> Settings { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}

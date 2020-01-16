using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamControl.Models
{
    public class Term: FullAuditedEntity
    {
        public Term()
        {
            Settings = new Collection<ObserveSetting>();
        }
       
        public int TermYear { get; set; }

       
        public string TermDesc { get; set; }

      
        public ICollection<ObserveSetting> Settings { get; set; }
    }
}

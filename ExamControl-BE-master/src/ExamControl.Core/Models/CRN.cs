using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExamControl.Models
{
    public class CRN: FullAuditedEntity
    {
      
        public CRN()
        {
            Settings = new Collection<ObserveSetting>();
        }

        public string CRNID { get; set; }


        public ICollection<ObserveSetting> Settings { get; set; }
    }
}

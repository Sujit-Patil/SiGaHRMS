using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGaHRMS.Data.Model.Entity
{
    public abstract class AuditedEntity
    {
        public long? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }

    }
}

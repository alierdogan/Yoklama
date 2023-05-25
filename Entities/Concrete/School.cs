using Entities.Concrete.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entities.Concrete
{
    public class School : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public bool ACTIVE { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }

        public virtual Province Province { get; set; }
        public virtual District District { get; set; }
        public virtual Neighbourhood Neighbourhood { get; set; }

        public virtual ICollection<SchoolTeacher>? Teachers { get; set; }
    }
}

using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Province : AuditableEntity
    {
        public int CODE { get; set; }
        public string NAME { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<District>? Districts { get; set; }
    }
}

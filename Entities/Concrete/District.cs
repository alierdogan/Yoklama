using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class District : AuditableEntity
    {
        public int CODE { get; set; }
        public string NAME { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<Neighbourhood> Neighbourhoods { get; set; }

    }
}

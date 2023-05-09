using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class District : AuditableEntity
    {
        public int CODE { get; set; }
        public string NAME { get; set; }
        public int PROVINCEREF { get; set; }
    }
}

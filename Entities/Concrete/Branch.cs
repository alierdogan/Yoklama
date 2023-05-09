using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Branch : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
    }
}

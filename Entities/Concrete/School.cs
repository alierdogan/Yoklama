using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class School : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
    }
}

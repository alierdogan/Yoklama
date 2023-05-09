using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Classroom : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
    }
}

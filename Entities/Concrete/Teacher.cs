using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Teacher : AuditableEntity
    {
        public int PersonId { get; set; }
    }
}

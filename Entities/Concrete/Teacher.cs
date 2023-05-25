using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Teacher : AuditableEntity
    {
        public int ACCESSCODE { get; set; }

        public virtual ICollection<SchoolTeacher> Schools { get; set; }
        public virtual Person Person { get; set; }
        public virtual Branch Branch { get; set; }
    }
}

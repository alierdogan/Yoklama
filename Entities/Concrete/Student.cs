using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Student : AuditableEntity
    {
        public string SCHOOLNUMBER { get; set; }

        public virtual Person Person { get; set; }
        public virtual School School { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}

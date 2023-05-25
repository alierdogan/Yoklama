using Entities.Concrete.Base;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StudentTimeTable : AuditableEntity
    {
        public DateTime DATE { get; set; }
        public DateTime START { get; set; }
        public DateTime END { get; set; }
        public int DURATION { get; set; }
        public bool ATTENDANCE { get; set; }

        public virtual School School { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}

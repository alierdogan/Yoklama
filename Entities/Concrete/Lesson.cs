using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Lesson : AuditableEntity
    {
        public int DURATION { get; set; }
        public int WEEKLYFREQUENCY { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual School School { get; set; }
    }
}

using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Lesson : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int DURATION { get; set; }
    }
}

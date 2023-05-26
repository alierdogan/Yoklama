using Entities.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SchoolTeacher : Entity
    {
        public School School { get; set; }
        public Teacher Teacher { get; set; }
        public bool ISDEFAULT { get; set; }
    }
}

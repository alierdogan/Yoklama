using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Teacher : AuditableEntity
    {
        private Person person;
        private Department department;
        private Branch branch;
        private Classroom classroom;
        private ICollection<School> schools;

        public Person? Person { get => person; set => person = value; }
        public Department? Department { get => department; set => department = value; }
        public Branch? Branch { get => branch; set => branch = value; }
        public Classroom? Classroom { get => classroom; set => classroom = value; }
        public ICollection<School>? Schools { get => schools; set => schools = value; }
    }
}

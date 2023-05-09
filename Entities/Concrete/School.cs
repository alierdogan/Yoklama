using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class School : AuditableEntity
    {
        private Province province;
        private District district;
        private Neighbourhood neighbourhood;
        private ICollection<Department> departments;
        private ICollection<Branch> branches;
        private ICollection<Classroom> classrooms;
        private ICollection<Student> students;
        private ICollection<Lesson> lessons;
        private ICollection<Teacher> teachers;

        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }

        public Province? Province { get => province; set => province = value; }
        public District? District { get => district; set => district = value; }
        public Neighbourhood? Neighbourhood { get => neighbourhood; set => neighbourhood = value; }
        public ICollection<Department>? Departments { get => departments; set => departments = value; }
        public ICollection<Branch>? Branches { get => branches; set => branches = value; }
        public ICollection<Classroom>? Classrooms { get => classrooms; set => classrooms = value; }
        public ICollection<Student>? Students { get => students; set => students = value; }
        public ICollection<Lesson>? Lessons { get => lessons; set => lessons = value; }
        public ICollection<Teacher>? Teachers { get => teachers; set => teachers = value; }
    }
}

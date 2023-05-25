using Entities.Concrete.Base;
using Entities.Enums;
using System.Runtime;

namespace Entities.Concrete
{
    public class User : AuditableEntity
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public UserType? UserType { get; set; }

        public virtual Person Person { get; set; }
    }
}

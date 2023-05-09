using Entities.Concrete.Base;
using System.Runtime;

namespace Entities.Concrete
{
    public class User : AuditableEntity
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public int PersonId { get; set; }
    }
}

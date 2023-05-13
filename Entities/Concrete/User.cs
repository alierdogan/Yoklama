using Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace Entities.Concrete
{
    public class User : AuditableEntity
    {
        [Required]
        [MaxLength(50)]
        public string USERNAME { get; set; }
        [Required]
        [MaxLength(50)]
        public string PASSWORD { get; set; }


        public int PersonId { get; set; }
    }
}

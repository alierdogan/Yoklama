using Entities.Concrete.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class School : AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public string NAME { get; set; }

        [MaxLength(1000)]
        public string DESCRIPTION { get; set; }

    }
}

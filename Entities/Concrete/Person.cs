using Entities.Concrete.Base;
using Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Person : AuditableEntity
    {
        [Required]
        public long MERNISNO { get; set; }
        [Required]
        [MaxLength(100)]
        public string NAME { get; set; }
        [Required]
        [MaxLength(100)]
        public string SURNAME { get; set; }
        public Gender? GENDER { get; set; }
        [MaxLength(11)]
        public string MOBILEPHONE { get; set; }
        [MaxLength(100)]
        public string EMAIL { get; set; }
        [MaxLength(500)]
        public string ADDRESS { get; set; }

        public virtual Province Province { get; set; }
        public virtual District District { get; set; }
        public virtual Neighbourhood Neighbourhood { get; set; }
    }
}

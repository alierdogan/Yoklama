using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete.Base
{
    public class Entity : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int STATUS { get; set; }
    }
}

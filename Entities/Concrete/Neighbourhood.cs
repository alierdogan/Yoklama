using Entities.Concrete.Base;

namespace Entities.Concrete
{
    public class Neighbourhood : AuditableEntity
    {
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }

        public virtual District District { get; set; }
    }
}

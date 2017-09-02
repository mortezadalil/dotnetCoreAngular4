using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
    public class WorkshopTag : BaseEntity
    {
        [ForeignKey("WorkshopId")]
        public Workshop Workshop { get; set; }
        public long WorkshopId { get; set; }

        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
        public long TagId { get; set; }
    }
}

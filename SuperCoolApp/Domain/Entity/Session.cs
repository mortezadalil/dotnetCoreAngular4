using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
    public class Session : BaseEntity
    {
        public string Title { get; set; }
        public int ViewOrder { get; set; }
        public int Duration { get; set; }
        public DateTime HoldingDateTime { get; set; }
        public string FileSrc { get; set; }

        [ForeignKey("WorkshopId")]
        public Workshop Workshop { get; set; }
        public long WorkshopId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
    public class WorkshopComment : BaseEntity
    {
        public string Text { get; set; }
        public decimal Rate { get; set; }

        [ForeignKey("UserId")]
        public UserDetail UserDetail { get; set; }
        public long UserId { get; set; }

        [ForeignKey("WorkshopId")]
        public Workshop Workshop { get; set; }
        public long WorkshopId { get; set; }


    }
}

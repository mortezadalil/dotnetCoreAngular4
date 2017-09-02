using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
    public class PostComment : BaseEntity
    {
        public string Text { get; set; }
        public decimal Rate { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public long PostId { get; set; }

        [ForeignKey("UserId")]
        public UserDetail UserDetail { get; set; }
        public long UserId { get; set; }

    }
}

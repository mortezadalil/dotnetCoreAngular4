using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
    public class PostTag : BaseEntity
    {
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public long PostId { get; set; }


        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
        public long TagId { get; set; }
    }
}

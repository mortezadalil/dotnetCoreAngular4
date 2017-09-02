using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
    public class CourseTag : BaseEntity
    {
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public long CourseId { get; set; }

        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
        public long TagId { get; set; }
    }
}

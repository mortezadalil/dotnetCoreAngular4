using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageSrc { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public long CategoryId { get; set; }

        public ICollection<CourseTag> CourseTags { get; set; }

        public ICollection<Workshop> Workshops { get; set; }
    }
}

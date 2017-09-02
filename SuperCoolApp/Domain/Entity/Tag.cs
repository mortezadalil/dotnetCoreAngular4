using System.Collections.Generic;

namespace SuperCoolApp.Domain.Entity
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<CourseTag> CourseTags { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public ICollection<WorkshopTag> WorkshopTags { get; set; }
    }
}

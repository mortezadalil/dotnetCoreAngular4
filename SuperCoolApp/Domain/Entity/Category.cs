using System.Collections.Generic;
using SuperCoolApp.Domain.Enum;

namespace SuperCoolApp.Domain.Entity
{
    public class Category : BaseEntity
    {
        public string Title { get; set; }
        public CategoryTypeEnum Type { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}

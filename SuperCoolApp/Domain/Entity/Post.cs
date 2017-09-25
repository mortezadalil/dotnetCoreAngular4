using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
  public class Post : BaseEntity
  {
    public string Title { get; set; }
    public string Content { get; set; }
    public string Summary { get; set; }
    public string UrlTitle { get; set; }

    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    public long CategoryId { get; set; }

    public ICollection<PostTag> PostTags { get; set; }

    public ICollection<PostComment> PostComments { get; set; }
  }
}

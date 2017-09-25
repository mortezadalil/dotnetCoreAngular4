using System.Collections.Generic;

namespace SuperCoolApp.Domain.Entity
{
  public class UserDetail : BaseEntity
  {
    public long UserId { get; set; }
    public string Test { get; set; }
    public ICollection<WorkshopComment> CourseComments { get; set; }
    public ICollection<PostComment> PostComments { get; set; }
    public ICollection<Workshop> Workshops { get; set; }
    public ICollection<Order> Orders { get; set; }



  }
}

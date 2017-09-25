using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCoolApp.Domain.Entity
{
  public class Workshop : BaseEntity
  {
    public string Title { get; set; }
    public int Duration { get; set; }
    public string ImageSrc { get; set; }
    public string Goal { get; set; }
    public string PreRequirements { get; set; }
    public string Description { get; set; }
    public DateTime HoldingDateTime { get; set; }
    public int Cost { get; set; }
    public decimal Rate { get; set; }
    public int RateCount { get; set; }
    public int RateSum { get; set; }
    public string PreviewVideoSrc { get; set; }

    [ForeignKey("CourseId")]
    public Course Course { get; set; }
    public long CourseId { get; set; }


    [ForeignKey("TeacherId")]
    public UserDetail UserDetail { get; set; }
    public long TeacherId { get; set; }

    public ICollection<WorkshopTag> WorkshopTags { get; set; }

    public ICollection<WorkshopComment> CourseComments { get; set; }
    public ICollection<Session> Sessions { get; set; }
    public ICollection<Order> Orders { get; set; }


  }
}

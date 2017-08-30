using System;
using System.ComponentModel.DataAnnotations;

namespace SuperCoolApp.Domain.Entity
{
  public class BaseEntity
  {
    [Key]
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDateTime { get; set; }


  }
}

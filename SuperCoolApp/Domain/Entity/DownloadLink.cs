using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SuperCoolApp.Domain.Enum;

namespace SuperCoolApp.Domain.Entity
{
  public class DownloadLink : BaseEntity
  {
    public string DownloadCount { get; set; }
    public Guid Guid{ get; set; }
    public DateTime ExpiredDate { get; set; }


    [ForeignKey("UserId")]
    public UserDetail User { get; set; }
    public long UserId { get; set; }
    
    public ICollection<WorkshopFile> WorkshopFiles { get; set; }

  }


}

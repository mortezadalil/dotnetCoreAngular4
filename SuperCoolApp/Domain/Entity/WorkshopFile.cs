using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SuperCoolApp.Domain.Enum;

namespace SuperCoolApp.Domain.Entity
{
  public class WorkshopFile : BaseEntity
  {
    public string FileSrc { get; set; }

    public FileTypeEnum FileType { get; set; }

    [ForeignKey("WorkshopId")]
    public Workshop Workshop { get; set; }
    public long WorkshopId { get; set; }
  }
}

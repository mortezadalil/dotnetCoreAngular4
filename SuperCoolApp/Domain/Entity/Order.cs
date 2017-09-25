using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SuperCoolApp.Domain.Enum;

namespace SuperCoolApp.Domain.Entity
{
  public class Order : BaseEntity
  {
    public OrderStatusEnum Status { get; set; }
    public string Description { get; set; }
    public string TransactionId { get; set; }
    

    [ForeignKey("UserId")]
    public UserDetail User { get; set; }
    public long UserId { get; set; }



    [ForeignKey("WorkshopId")]
    public Workshop Workshop { get; set; }
    public long WorkshopId { get; set; }
  }


}

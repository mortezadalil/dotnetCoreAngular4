using System.Collections.Generic;
using SuperCoolApp.Domain.Entity;

namespace SuperCoolApp.BL.Service.Interface
{
  public interface IUserDetailService
  {
    //IEnumerable<string> GetUsernameTest();
    //RegisterAppOutput RegisterApp(RegisterAppInput model, string serviceName);
    //AppItem CheckUserPass(Credential credential);

    List<UserDetail> getall();
  }
}

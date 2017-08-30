using System.Collections.Generic;
using SuperCoolApp.BL.Service.Interface;
using SuperCoolApp.Domain.Entity;
using SuperCoolApp.Domain.IRepository;

namespace SuperCoolApp.BL.Service
{
  public class UserDetailService : IUserDetailService
  {
    private readonly IUnitOfWork _unitOfWork;

    public UserDetailService(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

  //  public AppItem CheckUserPass(Credential credential)
  //  {
  //    Guid appId;
  //    Guid.TryParse(credential.AppId, out appId);
  //    var item = _unitOfWork.Apps.GetAll()
  //        .FirstOrDefault(
  //            x => x.AppId == appId && x.Username == credential.Username && x.Password == credential.Password);
  //    if (item == null) return null;
  //    return new AppItem()
  //    {
  //      Id = item.AppId.ToString(),
  //      Username = item.Username,
  //      Password = item.Password
  //    };
  //  }

  //  public RegisterAppOutput RegisterApp(RegisterAppInput model, string serviceName)
  //  {

  //    if (_unitOfWork.Apps.FindByName(model.ApplicationName) != null) throw new NameAlreadyExist();

  //    var item = _unitOfWork.Apps.Add(new App()
  //    {
  //      Username = model.Username,
  //      Password = model.Password,
  //      Name = model.ApplicationName,
  //      ClientUrl = model.ClientUrl
  //    });
  //    _unitOfWork.Save();

  //    return new RegisterAppOutput()
  //    {
  //      ApplicationKey = item.AppId,
  //      Port = serviceName.Split(':')[2],
  //      SocketUrl = serviceName + "/pushService"
  //    };
  //  }
  //  public IEnumerable<string> GetUsernameTest()
  //  {
  //    var d = _unitOfWork.Apps.GetAll().Select(x => x.Username).ToList();
  //    var e = _unitOfWork.Apps.GetAll().ToList();
  //    return d;
  //  }


    public List<UserDetail> getall()
    {
      return (List<UserDetail>) _unitOfWork.UserDetails.GetAll();
    }
  }
}

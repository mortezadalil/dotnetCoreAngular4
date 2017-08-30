using System;
using SuperCoolApp.Domain.Entity;
using SuperCoolApp.Domain.IRepository;

namespace SuperCoolApp.DAL.Repository
{
  public class UserDetailRepository : Repository<UserDetail>, IUserDetailRepository
  {
    private readonly CodemyDbContext _context;

    public UserDetailRepository(CodemyDbContext context) : base(context)
    {
      _context = context;
    }

    //public App FindByName(string modelApplicationName)
    //{
    //  return _context.Set<App>().FirstOrDefault(x => x.Name == modelApplicationName);
    //}

    //public App FindById(Guid appId)
    //{
    //  return _context.Set<App>().FirstOrDefault(x => x.AppId == appId && x.IsDeleted != true);
    //}

  }
}

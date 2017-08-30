using System;

namespace SuperCoolApp.Domain.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
    
        IUserDetailRepository UserDetails { get; }
   
        void Save();
    }
}

using System;
using SuperCoolApp.BL.Service;
using SuperCoolApp.BL.Service.Interface;
using SuperCoolApp.Domain.Entity;
using SuperCoolApp.Domain.IRepository;

namespace SuperCoolApp.DAL.Repository
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private CodemyDbContext _context;

    public UnitOfWork(CodemyDbContext context)
    {
      _context = context;
    }

    //Delete this default constructor if using an IoC container
    //public UnitOfWork()
    //    {
    //        _context = new CodemyDbContext();
    //    }
	
    
        //public IGroupdeviceRepository Groupdevices => new GroupdeviceRepository(_context);


        public IUserDetailRepository UserDetails => new UserDetailRepository(_context);


        //public IBaseRepository Bases => new BaseRepository(_context);


        //public IDeliveryRepository Deliveries => new DeliveryRepository(_context);


        //public IDeviceRepository Devices => new DeviceRepository(_context);


        //public IGroupRepository Groups => new GroupRepository(_context);


        //public ITopicdeviceRepository Topicdevices => new TopicdeviceRepository(_context);


        //public IMessageRepository Messages => new MessageRepository(_context);


        //public ITopicRepository Topics => new TopicRepository(_context);


        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}

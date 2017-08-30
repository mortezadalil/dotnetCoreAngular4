using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperCoolApp.BL.Service.Interface;
using SuperCoolApp.DAL;
using SuperCoolApp.Domain.Entity;
using SuperCoolApp.Domain.IRepository;

namespace SuperCoolApp.API
{
  [Route("api/[controller]")]
  public class UserDetailController : Controller
  {
    private readonly IUserDetailService _userDetailService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly CodemyDbContext _context;

    public UserDetailController(IUserDetailService userDetailService,
      IUnitOfWork unitOfWork,CodemyDbContext context)
    {
      _userDetailService = userDetailService;
      _unitOfWork = unitOfWork;
      _context = context;
    }

    // GET api/values/5
    [HttpGet]
    public List<UserDetail> Get()
    {
      var c = _context.UserDetails.ToList();
      var res2 = _unitOfWork.UserDetails.GetAll();

      var res = _userDetailService.getall();
      return res;
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
      //_dbContext.UserDetails.Add(new UserDetail() { UserId = 1 });
      //_dbContext.SaveChanges();
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }

}

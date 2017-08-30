using System.Linq;
using Microsoft.EntityFrameworkCore;
using SuperCoolApp.Domain.Entity;

namespace SuperCoolApp.DAL
{
  public class CodemyDbContext : DbContext
  {
    public CodemyDbContext()
    {
    }

    public CodemyDbContext(DbContextOptions<CodemyDbContext> options) : base(options)
    {

    }

    public DbSet<UserDetail> UserDetails { get; set; }
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
      {
        relationship.DeleteBehavior = DeleteBehavior.Restrict;
      }


      base.OnModelCreating(modelBuilder);
    }
  }
}

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
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseTag> CourseTags { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<PostComment> PostComments { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Workshop> Workshops { get; set; }
    public DbSet<WorkshopComment> WorkshopComments { get; set; }

    public DbSet<WorkshopTag> WorkShopTags { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Category> Categories { get; set; }



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

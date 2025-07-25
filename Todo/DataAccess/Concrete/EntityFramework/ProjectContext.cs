using Microsoft.EntityFrameworkCore;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Todo>().HasQueryFilter(t=>!t.IsDeleted);
        }

    }
}

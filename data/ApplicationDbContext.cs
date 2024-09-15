using Microsoft.EntityFrameworkCore;
using MyAspMvcBlog.Entities;

namespace MyAspMvcBlog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Blog> blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Blog>().HasData([
                new Blog { Id = 1, Title = "My first blog", Content = "This is my first blog" },
                new Blog { Id = 2, Title = "My second blog", Content = "This is my second blog" },
                new Blog { Id = 3, Title = "My third blog", Content = "This is my third blog" }
            ]);
        }
    }
}
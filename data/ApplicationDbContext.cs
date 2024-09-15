using Microsoft.EntityFrameworkCore;
using MyAspMvcPost.Entities;

namespace MyAspMvcPost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>().HasData([
                new Post { Id = 1, Title = "My first post", Content = "This is my first post", Image = "https://picsum.photos/200/300", UserId = 1, ReadTimeMinute = 5 },
                new Post { Id = 2, Title = "My second post", Content = "This is my second post", Image = "https://picsum.photos/200/300", UserId = 1, ReadTimeMinute = 5 },
                new Post { Id = 3, Title = "My third post", Content = "This is my third post", Image = "https://picsum.photos/200/300", UserId = 1, ReadTimeMinute = 5 }
            ]);
        }

    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAspMvcPost.Entities;

namespace MyAspMvcPost.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Posts 
            modelBuilder.Entity<Post>().HasData([
                new Post { Id = 1, Title = "My first post", Content = "This is my first post", Image = "https://picsum.photos/200/300", UserId = 1, ReadTimeMinute = 5 },
                new Post { Id = 2, Title = "My second post", Content = "This is my second post", Image = "https://picsum.photos/200/300", UserId = 1, ReadTimeMinute = 5 },
                new Post { Id = 3, Title = "My third post", Content = "This is my third post", Image = "https://picsum.photos/200/300", UserId = 1, ReadTimeMinute = 5 }
            ]);

            // Seed Roles 
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" }
            );

            // Seed Users
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@localhost",
                    NormalizedEmail = "ADMIN@LOCALHOST",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "admin@123"),
                    SecurityStamp = string.Empty
                }
            );

            // Seed UserRoles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }
            );
        }
    }
}
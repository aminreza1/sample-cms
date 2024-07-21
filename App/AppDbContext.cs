using ContentManagementSystem.Models;
using ContentManagementSystem.Models.Configs;
using Microsoft.EntityFrameworkCore;

namespace ContentManagementSystem.App
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {
            //Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArticleConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());

        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace EventLink.Models
{

    public class InstagramPostsContext: DbContext
    {
        public InstagramPostsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<InstagramPosts> InstagramPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstagramPosts>().Property(e => e.Id).IsRequired();

            modelBuilder.Entity<InstagramPosts>().Property(e => e.DisplayUrl).IsRequired();

            modelBuilder.Entity<InstagramPosts>().Property(e => e.Caption).IsRequired();

            modelBuilder.Entity<InstagramPosts>().Property(e => e.OwnerUsername).IsRequired();

            modelBuilder.Entity<InstagramPosts>().Property(e => e.OwnerFullName).IsRequired();

            modelBuilder.Entity<InstagramPosts>().Property(e => e.Url).IsRequired();



        }
    }
}

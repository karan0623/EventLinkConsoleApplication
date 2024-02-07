
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLinkConsoleApplication.Models
{
    internal class FacebookPostsContext: DbContext
    {
        public FacebookPostsContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<FacebookPosts> FacebookPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<FacebookPosts>().Property(e => e.PostId).IsRequired();

            modelBuilder.Entity<FacebookPosts>().Property(e => e.PageName).IsRequired();

            modelBuilder.Entity<FacebookPosts>().Property(e => e.Text).IsRequired();

            modelBuilder.Entity<FacebookPosts>().Property(e => e.Url).IsRequired();


        }
    }
}

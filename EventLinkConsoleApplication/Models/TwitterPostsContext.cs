using EventLinkConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLinkConsoleApplication.Models
{
    internal class TwitterPostsContext: DbContext
    {
        public TwitterPostsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TwitterPosts> TwitterPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instruction>().Property(e => e.Id).IsRequired();

            modelBuilder.Entity<User>().Property(e => e.Name).IsRequired();

            modelBuilder.Entity<Instruction>().Property(e => e.FullText).IsRequired();

            modelBuilder.Entity<Instruction>().Property(e => e.Url).IsRequired();



        }
    }
}

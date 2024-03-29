﻿using EventLinkConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        public DbSet<Instruction> TwitterPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instruction>().Property(e => e.Id).IsRequired();

            modelBuilder.Entity<Instruction>().Property(e => e.User).HasConversion(v => JsonConvert.SerializeObject(v),v => JsonConvert.DeserializeObject<User>(v));

            modelBuilder.Entity<Instruction>().Property(e => e.FullText).IsRequired();

            modelBuilder.Entity<Instruction>().Property(e => e.Url).IsRequired();



        }
    }
}

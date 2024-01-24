
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

        //public static string ExtractFacebookUsername(string url)
        //{
        //    try
        //    {
        //        Uri uri = new Uri(url);
        //        // Split the path of the URL by '/' and take the second segment
        //        string[] segments = uri.AbsolutePath.Split('/');
        //        if (segments.Length >= 2 && !string.IsNullOrEmpty(segments[1]))
        //        {
        //            return segments[1]; // Return the second segment which is the username
        //        }
        //        return string.Empty; // Return empty if the username segment is not found
        //    }
        //    catch (UriFormatException)
        //    {
        //        // Handle or log exception if the URL is not valid
        //        return string.Empty;
        //    }
        //}

        //public string Url { get; set; }

        //public string ConvertedUrl
        //{
        //    get => FacebookPostsContext.ExtractFacebookUsername(Url);
        //    set => Url = $"https://www.facebook.com/{value}";
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<FacebookPosts>().Property(e => e.ConvertedUrl)
            //.IsRequired()
            //.HasColumnName("Url"); // Map to the actual Url column in the database



            modelBuilder.Entity<FacebookPosts>().Property(e => e.Media).IsRequired();

            modelBuilder.Entity<FacebookPosts>().Property(e => e.Text).IsRequired();

            modelBuilder.Entity<FacebookPosts>().Property(e => e.Url).IsRequired();

        }
    }
}

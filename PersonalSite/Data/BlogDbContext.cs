using System;
using Microsoft.EntityFrameworkCore;
using PersonalSite.Models;
namespace PersonalSite.Data
{
    public class BlogDbContext : DbContext
    {
        
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }
    }
}

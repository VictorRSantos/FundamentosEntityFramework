using System;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(@"Server=DESKTOP\SQLEXPRESS;Database=Blog;User Id=sa;Password=123456;TrustServerCertificate=True");
            options.LogTo(Console.WriteLine);
        }



    }
}
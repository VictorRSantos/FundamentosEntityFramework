using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {

            using var context = new BlogDataContext();

            // var posts = GetPosts(context, 0, 25);

            // Mapeando Queries Puras e Views

        
        }

        public static List<Post> GetPosts(BlogDataContext context, int skip = 0, int take = 25)
        {
            var posts = context
                .Posts
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToList();

            return posts;
        }
    }
}

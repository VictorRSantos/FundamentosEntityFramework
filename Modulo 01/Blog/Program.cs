using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                /* CREATE */
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };                
                // context.Tags.Add(tag);
                // context.SaveChanges();

                /* UPDATE */
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                /* DELETE */
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
                // context.Remove(tag);
                // context.SaveChanges();


                /* ToList */
                // var tags = context.Tags.ToList();

                // foreach (var tag in tags)
                // {
                //     System.Console.WriteLine(tag.Name);
                // }

                /* AsNoTracking - na carrega Metadados e com isso aumenta a performance do EntityFramework*/
                // var tags = context.Tags.AsNoTracking().ToList();

                // foreach (var tag in tags)
                // {
                //     System.Console.WriteLine(tag.Name);
                // }

                /* First, Single */

                //var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 29);
                // var tag = context.Tags.AsNoTracking().First(x => x.Id == 3);

                // System.Console.WriteLine(tag?.Name);


            }
        }
    }
}

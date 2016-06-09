using EFCodeConfig.Models;
using System;
using System.Linq;
using System.Data.Entity;

namespace EFCodeConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var model = new Model())
            {
                {
                    var category = new Category
                    {
                        Title = $"New Category - @{DateTime.Now}"
                    };

                    var item = new Item
                    {
                        Category = category,
                        Name = $"New Item - @{DateTime.Now}"
                    };

                    model.Categories.Add(category);
                    model.Items.Add(item);

                    model.SaveChanges();
                }

                model.Categories.Include(e => e.Items).ToList().ForEach(category =>
                {
                    Console.WriteLine(category.Title);
                    category.Items.ToList().ForEach(item => Console.WriteLine($"\t{item.Name}"));
                });
            }
        }
    }
}

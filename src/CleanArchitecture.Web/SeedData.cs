using CleanArchitecture.Core.Entities;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CleanArchitecture.Web
{
    public static class SeedData
    {
        public static readonly ToDoItem ToDoItem1 = new ToDoItem
        {
            Title = "Get Sample Working",
            Description = "Try to get the sample to build."
        };
        public static readonly ToDoItem ToDoItem2 = new ToDoItem
        {
            Title = "Review Solution",
            Description = "Review the different projects in the solution and how they relate to one another."
        };
        public static readonly ToDoItem ToDoItem3 = new ToDoItem
        {
            Title = "Run and Review Tests",
            Description = "Make sure all the tests run and review what they are doing."
        };

        public static readonly User user1 = new User { Name = "Gilney" }; 
        public static readonly User user2 = new User { Name = "Manu" }; 
        public static readonly User user3 = new User { Name = "Lourdinha" }; 

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>(), null))
            {
                // Look for any TODO items.
                if (dbContext.ToDoItems.Any())
                {
                    return;   // DB has been seeded
                }

                PopulateTestData(dbContext);


            }
        }
        public static void PopulateTestData(AppDbContext dbContext)
        {
            foreach (var item in dbContext.ToDoItems)
            {
                dbContext.Remove(item);
            }
            foreach (var user in dbContext.Users)
            {
                dbContext.Remove(user);
            }
            dbContext.SaveChanges();

            dbContext.ToDoItems.Add(ToDoItem1);
            dbContext.ToDoItems.Add(ToDoItem2);
            dbContext.ToDoItems.Add(ToDoItem3);

            dbContext.Users.Add(user1);
            dbContext.Users.Add(user2);
            dbContext.Users.Add(user3);

            dbContext.SaveChanges();
        }
    }
}

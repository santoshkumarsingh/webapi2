namespace WebAPI2.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPI2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI2.Models.CustomerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAPI2.Models.CustomerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            Order order1 = new Order() { Amount = 120, ProductName = "Chai" };
            Order order2 = new Order() { Amount = 1120, ProductName = "Coffee" };
            Order order3 = new Order() { Amount = 10, ProductName = "Drink" };
            context.Customers.AddOrUpdate(c => c.Name,

                new Customer { Id = 1, Name = "Santosh", Email = "santosh@domain.com", Orders = new List<Order> { order1, order2 } },
                new Customer { Id = 2, Name = "Bill", Email = "Bill@domain.com", Orders = new List<Order> { order3 } });
        }
        
    }
}

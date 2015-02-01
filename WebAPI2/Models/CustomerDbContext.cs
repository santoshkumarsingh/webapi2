using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI2.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext()
            : base("name=CustomerDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}

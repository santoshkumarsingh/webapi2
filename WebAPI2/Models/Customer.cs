using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string ProductName { get; set; }
     
    }
}
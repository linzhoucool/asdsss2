using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset date { get; set; }
        public Customer Customer { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public Product Product { get; set; }
        public Employee Employee { get; set; }

    }
}
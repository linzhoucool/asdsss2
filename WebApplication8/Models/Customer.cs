using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Email { get; set; }

        [InverseProperty("Customer")]
        public ICollection<Sale> CustomerSales { get; set; }
    }
}
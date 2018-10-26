using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public ICollection<Sale> Sale { get; set; }


        [InverseProperty("StoreLocation")]
        public ICollection<Sale> Sales { get; set; }
    }
}


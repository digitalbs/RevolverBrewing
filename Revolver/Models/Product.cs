using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revolver.Models
{
    using System.ComponentModel.DataAnnotations;
    
    public class Product
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal ActualCost { get; set; }
        public decimal SalesCost { get; set; }
    }
}
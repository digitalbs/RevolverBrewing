using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revolver.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string Descriptions { get; set; }
        public decimal SalesCost { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price {get; set;}
    }
}
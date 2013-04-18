using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Revolver.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }

        //Navigtaion property
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
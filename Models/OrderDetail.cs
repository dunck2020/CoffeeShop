using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderManagerID { get; set; }
        public  int ProductID { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}

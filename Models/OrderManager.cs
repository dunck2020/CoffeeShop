using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class OrderManager
    {
        [Key]
        public int OrderManagerID { get; set; }
        [Column(TypeName = "nvarChar(50)")]
        public string OrderNumber { get; set; }
        public int CustomerID { get; set; }
        public decimal GrandTotal { get; set; }
        public int RewardPointTotal { get; set; }
    }
}


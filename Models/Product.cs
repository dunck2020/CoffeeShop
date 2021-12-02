using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [Column(TypeName = "nvarChar(100)")]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "nvarChar(200)")]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }


        private int _rewardPointValue;

        public int RewardPointValue
        {
            get { return _rewardPointValue; }
            set { _rewardPointValue = (int)Math.Ceiling(Price); }
        }

    }


}

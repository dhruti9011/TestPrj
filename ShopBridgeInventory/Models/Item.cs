using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeInventory.Models
{
    public class Product
    {
        [Key]
        public Guid Product_Code { get; set; }
        [Required]
        public string Product_Name { get; set; }
        [Required]
        public decimal Product_Price { get; set; }
        public string Product_Description { get; set; }
        public Category Category { get; set; }

    }
}

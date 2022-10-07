using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodFranchise.Models
{
    public class ItemModel
    {
        [Key]
        public int ItemId { get; set; }
        public String ItemName { get; set; }
        public int Price { get; set; }
        public String VegOrNonVeg { get; set; }
     
        public FastFoodShopModel FastFoodShopModel { get; set; }
       
    }
}

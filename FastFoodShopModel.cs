using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodFranchise.Models
{
    public class FastFoodShopModel
    {
        [Key]
        public int FastFoodShopId { get; set; }
        public String FastFoodShopName { get; set; }
        public String City { get; set; }
        public String PhoneNumber{ get; set; }
    }
}

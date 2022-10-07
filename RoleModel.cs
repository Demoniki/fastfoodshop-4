using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodFranchise.Models
{
    public class RoleModel
    {
        [Key]
        public int RoleId { get; set; }
        public String RoleName { get; set; }
    }
}

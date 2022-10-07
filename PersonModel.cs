using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodFranchise.Models
{
    public class PersonModel
    {
        [Key]
        public int PersonId { get; set; }
        public String PersonName { get; set; }
        public String Password{ get; set; }
        public String EmailId { get; set; }
        public String PersonCity { get; set; }
      
        public RoleModel RoleModel { get; set; }

        
    }
}

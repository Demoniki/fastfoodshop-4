using FastFoodFranchise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodFranchise.Data
{
    public class FastFoodShopAppDBcontext : DbContext
    {
        public FastFoodShopAppDBcontext(DbContextOptions<FastFoodShopAppDBcontext> options) : base(options)
        {

        }

        public DbSet<FastFoodShopModel> FastFoodShopModels { get; set; }
        public DbSet<ItemModel> ItemModels { get; set; }
        public DbSet<PersonModel> PersonModels { get; set; }
        public DbSet<RoleModel> RoleModels { get; set; }
    }
}

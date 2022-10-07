using FastFoodFranchise.Data;
using FastFoodFranchise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodFranchise.Repository
{
    public class FoodStoreApp : IFoodStoreRepository
    {
        private readonly FastFoodShopAppDBcontext _context;
        public FoodStoreApp(FastFoodShopAppDBcontext context)
        {
            _context = context;
        }
        //add
        public async Task<int> AddFoodShopByAsync(FastFoodShopModel food)
        {
            var nfood = new FastFoodShopModel()
            {
               FastFoodShopName = food.FastFoodShopName,
                City = food.City,
                PhoneNumber=food.PhoneNumber
            };
            _context.FastFoodShopModels.Add(nfood);
            await _context.SaveChangesAsync();
            return nfood.FastFoodShopId;
        }
    //get
    public async Task<List<FastFoodShopModel>> GetAllFoodShopAsync()
    {
        var records = await _context.FastFoodShopModels.Select(x => new FastFoodShopModel()
        {
          FastFoodShopId = x.FastFoodShopId,
           FastFoodShopName = x.FastFoodShopName,
            City = x.City


        }).ToListAsync();
        return records;
    }
        //getby id 
        public async Task<FastFoodShopModel> GetFoodShopByIdAsync(int fastfoodshopid)
        {
            var records = await _context.FastFoodShopModels.Where(x => x.FastFoodShopId == fastfoodshopid).Select(x => new FastFoodShopModel()
            {
                FastFoodShopId = x.FastFoodShopId,
                FastFoodShopName = x.FastFoodShopName,
                City = x.City

            }).FirstOrDefaultAsync();
            return records;
        }

        //delete
        public async Task DeleteFoodShopByAsync(int fastfoodshopid)
        {
        var dbook = new FastFoodShopModel() { FastFoodShopId = fastfoodshopid };

        _context.FastFoodShopModels.Remove(dbook);
        await _context.SaveChangesAsync();

    }

    //update
        public async Task UpdateFoodShopByAsync(int fastfoodshopid, FastFoodShopModel foodshopModel)
        {
        var nbook = await _context.FastFoodShopModels.FindAsync(fastfoodshopid);
        if (nbook != null)
        {
            nbook.FastFoodShopName= foodshopModel.FastFoodShopName;
            nbook.City = foodshopModel.City;
            await _context.SaveChangesAsync();
        }
    }
    }
}

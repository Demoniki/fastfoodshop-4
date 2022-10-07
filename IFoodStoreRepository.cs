using FastFoodFranchise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodFranchise.Repository
{
    public interface IFoodStoreRepository
    {
        //FastFoodShop
        Task<List<FastFoodShopModel>> GetAllFoodShopAsync();
        Task<FastFoodShopModel> GetFoodShopByIdAsync(int fastfoodshopid);
        Task<int> AddFoodShopByAsync(FastFoodShopModel food);
        Task DeleteFoodShopByAsync(int fastfoodshopid);

        Task UpdateFoodShopByAsync(int fastfoodshopid, FastFoodShopModel foodshopModel);

    }
}

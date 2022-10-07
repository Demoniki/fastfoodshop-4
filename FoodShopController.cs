using FastFoodFranchise.Models;
using FastFoodFranchise.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace FastFoodFranchise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodShopController:Controller
    { 
            private readonly IFoodStoreRepository _foodRepository;
            public FoodShopController(IFoodStoreRepository bookRepository)
            {
                this._foodRepository = bookRepository;
            }

            [HttpGet]
            public async Task<IActionResult> GetAllBooks()
            {
                var books = await _foodRepository.GetAllFoodShopAsync();
                return Ok(books);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetBooksById([FromRoute] int id)
            {
                var book = await _foodRepository.GetFoodShopByIdAsync(id);
                if (book == null)
                {
                    return NotFound();
                }
                return Ok(book);
            }

            [HttpPost("")]
            public async Task<IActionResult> AddNewFoodShop([FromBody] FastFoodShopModel bookmodel)
            {
                var id = await _foodRepository.AddFoodShopByAsync(bookmodel);
                return CreatedAtAction(nameof(GetBooksById), new { id = id, controller = "books" }, id);
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteFoodShop([FromRoute] int id)
            {
                await _foodRepository.DeleteFoodShopByAsync(id);
                return Ok();
            }
            [HttpPut("{id}")]
            public async Task<IActionResult> UpdatefoodShop([FromBody] FastFoodShopModel foodModel, [FromRoute] int id)
            {
                await _foodRepository.UpdateFoodShopByAsync(id, foodModel);
                return Ok();
            }
        }
}

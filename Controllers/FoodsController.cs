using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using FoodReview.Models;

namespace FoodReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly FoodReviewContext _db;

        public FoodsController(FoodReviewContext db)
        {
            _db = db;
        }

        // GET: api/Foods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Food>>> Get()
        {
            return await _db.Foods.ToListAsync();
        }

        // POST api/foods
        [HttpPost]
        public async Task<ActionResult<Food>> Post(Food food)
        {
            _db.Foods.Add(food);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = food.FoodId }, food);
        }
    }
}
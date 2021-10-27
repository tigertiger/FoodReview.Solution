using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ActionResult<IEnumerable<Food>>> Get(string name, string foodGroup, int rating)
        {
            var query = _db.Foods.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            // if (foodGroup != null)
            // {
            //     query = query.Where(entry => entry.FoodGroup == foodGroup);
            // }

            // if (rating != 0)
            // {
            //     query = query.Where(entry => entry.Rating == rating);
            // }

            return await query.ToListAsync();
        }

        // POST api/foods
        [HttpPost]
        public async Task<ActionResult<Food>> Post(Food food, int RatingId)
        {
            _db.Foods.Add(food);
            _db.FoodRating.Add(new FoodRating() {RatingId = RatingId, FoodId = food.FoodId});
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFood), new { id = food.FoodId }, food);
        }
        
        // GET api/foods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(int id)
        {
            var food = await _db.Foods.FindAsync(id);

            if (food == null)
            {
                return NotFound();
            }

            return food;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Food food)
        {
          if (id != food.FoodId)
          {
            return BadRequest();
          }

          _db.Entry(food).State = EntityState.Modified;

          try
          {
            await _db.SaveChangesAsync();
          }
          catch (DbUpdateConcurrencyException)
          {
            if (!FoodExists(id))
            {
              return NotFound();
            }
            else
            {
              throw;
            }
          }
          return NoContent();
        }
        // DELETE: api/Foods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {
          var food = await _db.Foods.FindAsync(id);
          if (food == null)
          {
            return NotFound();
          }
          _db.Foods.Remove(food);
          await _db.SaveChangesAsync();

          return NoContent();
          }

        private bool FoodExists(int id)
        {
          return _db.Foods.Any(e => e.FoodId == id);
        }
        }
    }
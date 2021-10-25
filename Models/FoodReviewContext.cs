using Microsoft.EntityFrameworkCore;

namespace FoodReview.Models
{
    public class FoodReviewContext : DbContext
    {
        public FoodReviewContext(DbContextOptions<FoodReviewContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}
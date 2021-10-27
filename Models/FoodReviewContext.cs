using Microsoft.EntityFrameworkCore;


namespace FoodReview.Models
{
    public class FoodReviewContext : DbContext
    {
        public FoodReviewContext(DbContextOptions<FoodReviewContext> options)
            : base(options)
        {
        }
        public DbSet<Image> Images { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<FoodRating> FoodRating { get; set; }
        public DbSet<Review> Reviews {get; set;}
        public DbSet<Pyramid> Pyramid { get; set; }
        public DbSet<FoodGroup> FoodGroup { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            builder.Entity<FoodGroup>()
            .HasData(
                new FoodGroup { FoodGroupId = 1, FgName = "Dairy" }

            );

            builder.Entity<Food>()
            .HasData(
                new Food { FoodId = 1, Name = "Milk"}
            );
            
            builder.Entity<Image>()
            .HasData(
                new Image { ImageId = 1, FoodId = 1, ImageLocation = "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21", ImageName = "glass of milk" }
            );
            
            builder.Entity<Review>()
            .HasData(
                new Review {ReviewId = 1, FoodId = 1, ReviewText = "It's good in coffee."}
            );
            
            builder.Entity<Rating>()
            .HasData(
                new Rating { RatingId = 1, Stars = 3}
            );

            builder.Entity<FoodRating>()
            .HasData(
                new FoodRating { FoodRatingId = 1, FoodId =1, RatingId = 1 }
            );

                builder.Entity<Pyramid>()
                .HasData(
                new Pyramid { PyramidId = 1, FoodGroupId =1, FoodId = 1 }
            );
        }

    }
}


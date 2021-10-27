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
                new FoodGroup { FoodGroupId = 1, FgName = "Dairy" },
                new FoodGroup { FoodGroupId = 2, FgName = "Grain" },
                new FoodGroup { FoodGroupId = 3, FgName = "Protein" }

            );

            builder.Entity<Food>()
            .HasData(
                new Food { FoodId = 1, Name = "Milk"},
                new Food { FoodId = 2, Name = "Bread"},
                new Food { FoodId = 3, Name = "Eggs"},
                new Food { FoodId = 4, Name = "Breakfast Cereal"}
            );
            
            builder.Entity<Image>()
            .HasData(
                new Image { ImageId = 1, FoodId = 1, ImageLocation = "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21", ImageName = "glass of milk" },
                new Image { ImageId = 2, FoodId = 2, ImageLocation = "https://unsplash.com/photos/e83dQJ-BMog", ImageName = "bread" },
                new Image { ImageId = 3, FoodId = 3, ImageLocation = "https://www.simplyrecipes.com/thmb/akJysvaQmkQpLt7Q2_SfA_jr2PU=/800x533/filters:fill(auto,1)/__opt__aboutcom__coeus__resources__content_migration__simply_recipes__uploads__2014__07__hard-boiled-eggs-horiz-800-429f7e9948b84a6d84237e228f9d54f2.jpg", ImageName = "eggs" },
                new Image { ImageId = 4, FoodId = 4, ImageLocation = "https://images.unsplash.com/photo-1578831914933-6339766eb29b?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=387&q=80", ImageName = "b in cereal"}

            );
            
            builder.Entity<Review>()
            .HasData(
                new Review {ReviewId = 1, FoodId = 1, ReviewText = "It's good in coffee."},
                new Review {ReviewId = 2, FoodId = 2, ReviewText = "There is not a thing that is more positive than bread. - Fyodor Dostoevsky"},
                new Review {ReviewId = 3, FoodId = 3, ReviewText = "Eggs are the best."},
                new Review {ReviewId = 4, FoodId = 4, ReviewText = "It depends."}

            );
            
            builder.Entity<Rating>()
            .HasData(
                new Rating { RatingId = 1, Stars = 3},
                new Rating { RatingId = 2, Stars = 5},
                new Rating { RatingId = 3, Stars = 5},
                new Rating { RatingId = 4, Stars = 2}
            );

            builder.Entity<FoodRating>()
            .HasData(
                new FoodRating { FoodRatingId = 1, FoodId =1, RatingId = 1 },
                new FoodRating { FoodRatingId = 2, FoodId =2, RatingId = 2 },
                new FoodRating { FoodRatingId = 3, FoodId =3, RatingId = 3 },
                new FoodRating { FoodRatingId = 4, FoodId =4, RatingId = 4 }
            );

                builder.Entity<Pyramid>()
                .HasData(
                new Pyramid { PyramidId = 1, FoodGroupId =1, FoodId = 1 },
                new Pyramid { PyramidId = 2, FoodGroupId =2, FoodId = 2 },
                new Pyramid { PyramidId = 3, FoodGroupId =3, FoodId = 3 },
                new Pyramid { PyramidId = 4, FoodGroupId =2, FoodId = 4 }
            );
        }

    }
}


using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace FoodReview.Models
{
    public class FoodReviewContext : DbContext
    {
        public FoodReviewContext(DbContextOptions<FoodReviewContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<FoodRating> FoodRating { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Food>()
            .HasData(
                new Food { FoodId = 1, Name = "Milk", FoodGroup = "Dairy", Review = "It's good in coffee.", ImageName = "glass of milk", ImageLocation = "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21"},
                new Food { FoodId = 2, Name = "Hamburger", FoodGroup = "Meat", Review = "This is a good standard food, when you're hungry. It'll fill you up.", ImageName = "hamburger", ImageLocation = "https://d1nqx6es26drid.cloudfront.net/app/uploads/2015/04/04043817/product-hamburger.png"},
                new Food { FoodId = 3, Name = "Pizza", FoodGroup = "Dinner", Review = "This food needs no review because it's the only food that actually matters. Grab a slice, kick back, and relish in the fact that you just took a bite out of heaven.", ImageName = "Slice of Pizza", ImageLocation = "https://www.istockphoto.com/photo/cheesy-pepperoni-pizza-gm938742222-256696208" },
                new Food { FoodId = 4, Name = "Peas", FoodGroup = "Vegetables", Review = "These little nightmare balls serve no purpose other than to ruin the rest of your meal by tainting your palate.", ImageName = "Peas", ImageLocation = "https://images.indianexpress.com/2019/12/Peas_759.jpg" },
                
                new Food { FoodId = 5, Name = "Carrot", FoodGroup = "Vegetable", Review = "Crunchy. Orange. Snowman noses. What more do you want?", ImageName = "carrots", ImageLocation = "https://www.freshpoint.com/wp-content/uploads/commodity-carrot.jpg"},

                new Food { FoodId = 6, Name = "Breakfast Cereal", FoodGroup = "Breakfast", Review = "Depends.", ImageName = "breakfast cereal", ImageLocation = "https://4eojie3jgd8h1h57zz1bwc39-wpengine.netdna-ssl.com/wp-content/uploads/2018/12/PurelyOs_Main_1028.png"}
            );

            builder.Entity<Rating>()
            .HasData(
                new Rating { RatingId = 1, Stars = 2},
                new Rating { RatingId = 2, Stars = 3},
                new Rating { RatingId = 3, Stars = 5},
                new Rating { RatingId = 4, Stars = 1},
                new Rating { RatingId = 5, Stars = 5},
                new Rating { RatingId = 6, Stars = 3}
            );

            builder.Entity<FoodRating>()
            .HasData(
                new FoodRating { FoodRatingId = 1, FoodId =1, RatingId = 1 },
                new FoodRating { FoodRatingId = 2, FoodId =2, RatingId = 2 },
                new FoodRating { FoodRatingId = 3, FoodId =3, RatingId = 3 },
                new FoodRating { FoodRatingId = 4, FoodId =4, RatingId = 4 },
                new FoodRating { FoodRatingId = 5, FoodId =5, RatingId = 5 },
                new FoodRating { FoodRatingId = 6, FoodId =6, RatingId = 6 }
            );
        }

    }
}


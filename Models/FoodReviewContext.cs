using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodReview.Models
{
    public class FoodReviewContext : DbContext
    {
        public FoodReviewContext(DbContextOptions<FoodReviewContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Food>()
            .HasData(
                new Food { FoodId = 1, Name = "Milk", FoodGroup = "Dairy", Rating = 2, Review = "It's good in coffee.", ImageName = "glass of milk", ImageLocation = "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21"},
                new Food { FoodId = 2, Name = "Hamburger", FoodGroup = "Meat", Rating = 3, Review = "This is a good standard food, when you're hungry. It'll fill you up.", ImageName = "hamburger", ImageLocation = "https://d1nqx6es26drid.cloudfront.net/app/uploads/2015/04/04043817/product-hamburger.png"},
                new Food { FoodId = 3, Name = "Pizza", FoodGroup = "Dinner", Rating = 5, Review = "This food needs no review because it's the only food that actually matters. Grab a slice, kick back, and relish in the fact that you just took a bite out of heaven.", ImageName = "Slice of Pizza", ImageLocation = "https://www.istockphoto.com/photo/cheesy-pepperoni-pizza-gm938742222-256696208" },
                new Food { FoodId = 4, Name = "Peas", FoodGroup = "Vegetables", Rating = 1, Review = "These little nightmare balls serve no purpose other than to ruin the rest of your meal by tainting your palate.", ImageName = "Peas", ImageLocation = "https://images.indianexpress.com/2019/12/Peas_759.jpg" },
                
                new Food { FoodId = 5, Name = "Carrot", FoodGroup = "Vegetable", Rating = 5, Review = "Crunchy. Orange. Snowman noses. What more do you want?", ImageName = "carrots", ImageLocation = "https://www.freshpoint.com/wp-content/uploads/commodity-carrot.jpg"},

                new Food { FoodId = 6, Name = "Breakfast Cereal", FoodGroup = "Breakfast", Rating = 3, Review = "Depends.", ImageName = "breakfast cereal", ImageLocation = "https://4eojie3jgd8h1h57zz1bwc39-wpengine.netdna-ssl.com/wp-content/uploads/2018/12/PurelyOs_Main_1028.png"}
            );
        }

    }
}
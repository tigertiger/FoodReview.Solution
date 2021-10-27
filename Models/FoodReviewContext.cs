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
                new Food { FoodId = 1, Name = "Milk", Review = "It's good in coffee.", ImageName = "glass of milk", ImageLocation = "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21"}
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


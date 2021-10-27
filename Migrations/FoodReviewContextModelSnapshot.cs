﻿// <auto-generated />
using FoodReview.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodReview.Solution.Migrations
{
    [DbContext(typeof(FoodReviewContext))]
    partial class FoodReviewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FoodReview.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageLocation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImageName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            ImageLocation = "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21",
                            ImageName = "glass of milk",
                            Name = "Milk",
                            Review = "It's good in coffee."
                        });
                });

            modelBuilder.Entity("FoodReview.Models.FoodGroup", b =>
                {
                    b.Property<int>("FoodGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FgName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FoodGroupId");

                    b.ToTable("FoodGroup");

                    b.HasData(
                        new
                        {
                            FoodGroupId = 1,
                            FgName = "Dairy"
                        });
                });

            modelBuilder.Entity("FoodReview.Models.FoodRating", b =>
                {
                    b.Property<int>("FoodRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.HasKey("FoodRatingId");

                    b.HasIndex("FoodId");

                    b.HasIndex("RatingId");

                    b.ToTable("FoodRating");

                    b.HasData(
                        new
                        {
                            FoodRatingId = 1,
                            FoodId = 1,
                            RatingId = 1
                        });
                });

            modelBuilder.Entity("FoodReview.Models.Pyramid", b =>
                {
                    b.Property<int>("PyramidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FoodGroupId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.HasKey("PyramidId");

                    b.HasIndex("FoodGroupId");

                    b.HasIndex("FoodId");

                    b.ToTable("Pyramid");

                    b.HasData(
                        new
                        {
                            PyramidId = 1,
                            FoodGroupId = 1,
                            FoodId = 1
                        });
                });

            modelBuilder.Entity("FoodReview.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            Stars = 3
                        });
                });

            modelBuilder.Entity("FoodReview.Models.FoodRating", b =>
                {
                    b.HasOne("FoodReview.Models.Food", "Food")
                        .WithMany("JoinEntities")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodReview.Models.Rating", "Rating")
                        .WithMany("JoinEntities")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("FoodReview.Models.Pyramid", b =>
                {
                    b.HasOne("FoodReview.Models.FoodGroup", "FoodGroup")
                        .WithMany("JoinEntities2")
                        .HasForeignKey("FoodGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodReview.Models.Food", "Food")
                        .WithMany("JoinEntities2")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("FoodGroup");
                });

            modelBuilder.Entity("FoodReview.Models.Food", b =>
                {
                    b.Navigation("JoinEntities");

                    b.Navigation("JoinEntities2");
                });

            modelBuilder.Entity("FoodReview.Models.FoodGroup", b =>
                {
                    b.Navigation("JoinEntities2");
                });

            modelBuilder.Entity("FoodReview.Models.Rating", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}

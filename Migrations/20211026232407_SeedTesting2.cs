using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodReview.Solution.Migrations
{
    public partial class SeedTesting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodRating",
                columns: new[] { "FoodRatingId", "FoodId", "RatingId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodRating",
                keyColumn: "FoodRatingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodRating",
                keyColumn: "FoodRatingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodRating",
                keyColumn: "FoodRatingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodRating",
                keyColumn: "FoodRatingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodRating",
                keyColumn: "FoodRatingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodRating",
                keyColumn: "FoodRatingId",
                keyValue: 6);
        }
    }
}

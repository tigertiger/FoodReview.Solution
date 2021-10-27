using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodReview.Solution.Migrations
{
    public partial class MoreSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodGroup",
                columns: new[] { "FoodGroupId", "FgName" },
                values: new object[,]
                {
                    { 2, "Grain" },
                    { 3, "Protein" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Name" },
                values: new object[,]
                {
                    { 2, "Bread" },
                    { 3, "Eggs" },
                    { 4, "Breakfast Cereal" }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "Stars" },
                values: new object[,]
                {
                    { 2, 5 },
                    { 3, 5 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "FoodRating",
                columns: new[] { "FoodRatingId", "FoodId", "RatingId" },
                values: new object[,]
                {
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "FoodId", "ImageLocation", "ImageName" },
                values: new object[,]
                {
                    { 2, 2, "https://unsplash.com/photos/e83dQJ-BMog", "bread" },
                    { 3, 3, "https://www.simplyrecipes.com/thmb/akJysvaQmkQpLt7Q2_SfA_jr2PU=/800x533/filters:fill(auto,1)/__opt__aboutcom__coeus__resources__content_migration__simply_recipes__uploads__2014__07__hard-boiled-eggs-horiz-800-429f7e9948b84a6d84237e228f9d54f2.jpg", "eggs" },
                    { 4, 4, "https://images.unsplash.com/photo-1578831914933-6339766eb29b?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=387&q=80", "b in cereal" }
                });

            migrationBuilder.InsertData(
                table: "Pyramid",
                columns: new[] { "PyramidId", "FoodGroupId", "FoodId" },
                values: new object[,]
                {
                    { 2, 2, 2 },
                    { 4, 2, 4 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "FoodId", "ReviewText" },
                values: new object[,]
                {
                    { 2, 2, "There is not a thing that is more positive than bread. - Fyodor Dostoevsky" },
                    { 3, 3, "Eggs are the best." },
                    { 4, 4, "It depends." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pyramid",
                keyColumn: "PyramidId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pyramid",
                keyColumn: "PyramidId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pyramid",
                keyColumn: "PyramidId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodGroup",
                keyColumn: "FoodGroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodGroup",
                keyColumn: "FoodGroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingId",
                keyValue: 4);
        }
    }
}

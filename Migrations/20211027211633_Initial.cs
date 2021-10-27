using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodReview.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodGroup",
                columns: table => new
                {
                    FoodGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FgName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodGroup", x => x.FoodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Review = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    ImageName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ImageLocation = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Stars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingId);
                });

            migrationBuilder.CreateTable(
                name: "Pyramid",
                columns: table => new
                {
                    PyramidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    FoodGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pyramid", x => x.PyramidId);
                    table.ForeignKey(
                        name: "FK_Pyramid_FoodGroup_FoodGroupId",
                        column: x => x.FoodGroupId,
                        principalTable: "FoodGroup",
                        principalColumn: "FoodGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pyramid_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodRating",
                columns: table => new
                {
                    FoodRatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    RatingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRating", x => x.FoodRatingId);
                    table.ForeignKey(
                        name: "FK_FoodRating_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodRating_Rating_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Rating",
                        principalColumn: "RatingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodGroup",
                columns: new[] { "FoodGroupId", "FgName" },
                values: new object[] { 1, "Dairy" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "ImageLocation", "ImageName", "Name", "Review" },
                values: new object[] { 1, "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21", "glass of milk", "Milk", "It's good in coffee." });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "Stars" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "FoodRating",
                columns: new[] { "FoodRatingId", "FoodId", "RatingId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Pyramid",
                columns: new[] { "PyramidId", "FoodGroupId", "FoodId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_FoodRating_FoodId",
                table: "FoodRating",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodRating_RatingId",
                table: "FoodRating",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Pyramid_FoodGroupId",
                table: "Pyramid",
                column: "FoodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Pyramid_FoodId",
                table: "Pyramid",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodRating");

            migrationBuilder.DropTable(
                name: "Pyramid");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "FoodGroup");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}

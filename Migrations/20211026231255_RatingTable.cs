using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodReview.Solution.Migrations
{
    public partial class RatingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Foods");

            migrationBuilder.AlterColumn<string>(
                name: "Review",
                table: "Foods",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldMaxLength: 10000,
                oldNullable: true);

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
                table: "Rating",
                columns: new[] { "RatingId", "Stars" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 5 },
                    { 4, 1 },
                    { 5, 5 },
                    { 6, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodRating_FoodId",
                table: "FoodRating",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodRating_RatingId",
                table: "FoodRating",
                column: "RatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodRating");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.AlterColumn<string>(
                name: "Review",
                table: "Foods",
                type: "longtext CHARACTER SET utf8mb4",
                maxLength: 10000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                column: "Rating",
                value: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodReview.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    FoodGroup = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 10000, nullable: true),
                    ImageName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ImageLocation = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodGroup", "ImageLocation", "ImageName", "Name", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Dairy", "https://www.refinery29.com/images/10001972.jpg?crop=40%3A21", "glass of milk", "Milk", 2, "It's good in coffee." },
                    { 2, "Meat", "https://d1nqx6es26drid.cloudfront.net/app/uploads/2015/04/04043817/product-hamburger.png", "hamburger", "Hamburger", 3, "This is a good standard food, when you're hungry. It'll fill you up." },
                    { 3, "Dinner", "https://www.istockphoto.com/photo/cheesy-pepperoni-pizza-gm938742222-256696208", "Slice of Pizza", "Pizza", 5, "This food needs no review because it's the only food that actually matters. Grab a slice, kick back, and relish in the fact that you just took a bite out of heaven." },
                    { 4, "Vegetables", "https://images.indianexpress.com/2019/12/Peas_759.jpg", "Peas", "Peas", 1, "These little nightmare balls serve no purpose other than to ruin the rest of your meal by tainting your palate." },
                    { 5, "Vegetable", "https://www.freshpoint.com/wp-content/uploads/commodity-carrot.jpg", "carrots", "Carrot", 5, "Crunchy. Orange. Snowman noses. What more do you want?" },
                    { 6, "Breakfast", "https://4eojie3jgd8h1h57zz1bwc39-wpengine.netdna-ssl.com/wp-content/uploads/2018/12/PurelyOs_Main_1028.png", "breakfast cereal", "Breakfast Cereal", 3, "Depends." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}

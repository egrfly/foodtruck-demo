using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodTruck.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CupboardStock",
                columns: table => new
                {
                    Item = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupboardStock", x => x.Item);
                });

            migrationBuilder.CreateTable(
                name: "FridgeStock",
                columns: table => new
                {
                    Item = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FridgeStock", x => x.Item);
                });

            migrationBuilder.InsertData(
                table: "CupboardStock",
                columns: new[] { "Item", "Quantity" },
                values: new object[,]
                {
                    { "Egg", 0 },
                    { "Garlic", 0 },
                    { "Onion", 0 }
                });

            migrationBuilder.InsertData(
                table: "FridgeStock",
                columns: new[] { "Item", "Quantity" },
                values: new object[,]
                {
                    { "Beef", 0 },
                    { "Butter", 0 },
                    { "Cheese", 0 },
                    { "Ham", 0 },
                    { "Pancetta", 0 },
                    { "Pepperoni", 0 },
                    { "Pineapple", 0 },
                    { "RedChilli", 0 },
                    { "TomatoSauce", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CupboardStock");

            migrationBuilder.DropTable(
                name: "FridgeStock");
        }
    }
}

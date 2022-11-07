using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PentaPizza.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Product");

            migrationBuilder.CreateTable(
                name: "Pizzas",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Product",
                table: "Pizzas",
                columns: new[] { "Id", "Ingredients", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Tomato , Mozarella", "Margherita", 5.0 },
                    { 2, "Tomato , Mozarella, Di Bufala", "Bufala", 6.0 },
                    { 3, "Tomato , Mozarella, Anchovies, Oregano, Oil", "Romana", 5.0 },
                    { 4, "Tomato , Mozarella, Spicy Salami", "Diavola", 7.5 },
                    { 5, "Mozarella, Oregano", "Mozarella", 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas",
                schema: "Product");
        }
    }
}

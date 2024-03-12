using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShopSwaggerUI2.Migrations
{
    public partial class create_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceGame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}

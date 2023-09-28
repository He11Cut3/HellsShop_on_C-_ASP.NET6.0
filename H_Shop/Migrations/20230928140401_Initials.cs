using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H_Shop.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HShopProducts",
                columns: table => new
                {
                    HShopProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HShopProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HShopProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HShopProductCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HShopProducts", x => x.HShopProductID);
                });

            migrationBuilder.CreateTable(
                name: "HShopUsers",
                columns: table => new
                {
                    HShopUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HShopLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HShopPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HShopUsers", x => x.HShopUserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HShopProducts");

            migrationBuilder.DropTable(
                name: "HShopUsers");
        }
    }
}

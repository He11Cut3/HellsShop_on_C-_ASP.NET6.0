using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H_Shop.Migrations
{
    public partial class InitialsNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "HShopProductImage",
                table: "HShopProducts",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HShopProductImage",
                table: "HShopProducts");
        }
    }
}

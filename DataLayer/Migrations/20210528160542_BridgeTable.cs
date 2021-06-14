using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class BridgeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_TBOrdersId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TBOrdersId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TBOrdersId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "TBOrdersTBProducts",
                columns: table => new
                {
                    OrdersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBOrdersTBProducts", x => new { x.OrdersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_TBOrdersTBProducts_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBOrdersTBProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBOrdersTBProducts_ProductsId",
                table: "TBOrdersTBProducts",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBOrdersTBProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "TBOrdersId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_TBOrdersId",
                table: "Products",
                column: "TBOrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_TBOrdersId",
                table: "Products",
                column: "TBOrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

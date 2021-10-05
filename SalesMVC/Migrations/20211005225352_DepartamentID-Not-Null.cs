using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesMVC.Migrations
{
    public partial class DepartamentIDNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentsId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartamentsId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartamentsId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentID",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartamentID",
                table: "Seller",
                column: "DepartamentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentID",
                table: "Seller",
                column: "DepartamentID",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentID",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartamentID",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartamentID",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentsId",
                table: "Seller",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartamentsId",
                table: "Seller",
                column: "DepartamentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentsId",
                table: "Seller",
                column: "DepartamentsId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

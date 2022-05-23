using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsRental.Migrations
{
    public partial class addingAssociationsBetweenClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Rent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Rent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_CarId",
                table: "Rent",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_UserId",
                table: "Rent",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Car_CarId",
                table: "Rent",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_User_UserId",
                table: "Rent",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Car_CarId",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_User_UserId",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_CarId",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_UserId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rent");
        }
    }
}

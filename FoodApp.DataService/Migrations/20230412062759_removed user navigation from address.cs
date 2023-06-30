using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.ORM.Migrations
{
    /// <inheritdoc />
    public partial class removedusernavigationfromaddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AppUser",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_AppUserId",
                table: "Address",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AppUser_AppUserId",
                table: "Address",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AppUser_AppUserId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_AppUserId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Address");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AppUser",
                table: "Address",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

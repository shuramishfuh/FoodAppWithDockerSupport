using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.ORM.Migrations
{
    /// <inheritdoc />
    public partial class refreshtokentousermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AppUser",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AppUser",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RefreshTokenIsActive",
                table: "AppUser",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "RefreshTokenIsActive",
                table: "AppUser");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AppUser",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AppUser",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);
        }
    }
}

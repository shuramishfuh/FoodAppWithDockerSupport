using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.ORM.Migrations
{
    /// <inheritdoc />
    public partial class role_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "user");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AppUser");
        }
    }
}

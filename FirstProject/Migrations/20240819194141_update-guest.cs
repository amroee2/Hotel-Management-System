using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstProject.Migrations
{
    /// <inheritdoc />
    public partial class updateguest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuestAddess",
                schema: "HotelManagementSystem",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "GuestFirstName",
                schema: "HotelManagementSystem",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "GuestLastName",
                schema: "HotelManagementSystem",
                table: "Guest");

            migrationBuilder.RenameColumn(
                name: "GuestPhone",
                schema: "HotelManagementSystem",
                table: "Guest",
                newName: "GuestUserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuestUserName",
                schema: "HotelManagementSystem",
                table: "Guest",
                newName: "GuestPhone");

            migrationBuilder.AddColumn<string>(
                name: "GuestAddess",
                schema: "HotelManagementSystem",
                table: "Guest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GuestFirstName",
                schema: "HotelManagementSystem",
                table: "Guest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GuestLastName",
                schema: "HotelManagementSystem",
                table: "Guest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

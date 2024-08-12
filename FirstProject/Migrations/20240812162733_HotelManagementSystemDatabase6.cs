using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstProject.Migrations
{
    /// <inheritdoc />
    public partial class HotelManagementSystemDatabase6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelDetail_Hotel_HotelRef",
                schema: "HotelManagementSystem",
                table: "HotelDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Guest_GuestRef",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Room_RoomRef",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotel_HotelRef",
                schema: "HotelManagementSystem",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDetail_Room_RoomRef",
                schema: "HotelManagementSystem",
                table: "RoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_RoomDetail_RoomRef",
                schema: "HotelManagementSystem",
                table: "RoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_Room_HotelRef",
                schema: "HotelManagementSystem",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_GuestRef",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_RoomRef",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_HotelDetail_HotelRef",
                schema: "HotelManagementSystem",
                table: "HotelDetail");

            migrationBuilder.DropColumn(
                name: "RoomRef",
                schema: "HotelManagementSystem",
                table: "RoomDetail");

            migrationBuilder.DropColumn(
                name: "HotelRef",
                schema: "HotelManagementSystem",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "GuestRef",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "RoomRef",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "HotelRef",
                schema: "HotelManagementSystem",
                table: "HotelDetail");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetail_RoomId",
                schema: "HotelManagementSystem",
                table: "RoomDetail",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelID",
                schema: "HotelManagementSystem",
                table: "Room",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_GuestID",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RoomId",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelDetail_HotelID",
                schema: "HotelManagementSystem",
                table: "HotelDetail",
                column: "HotelID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelDetail_Hotel_HotelID",
                schema: "HotelManagementSystem",
                table: "HotelDetail",
                column: "HotelID",
                principalSchema: "HotelManagementSystem",
                principalTable: "Hotel",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Guest_GuestID",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "GuestID",
                principalSchema: "HotelManagementSystem",
                principalTable: "Guest",
                principalColumn: "GuestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Room_RoomId",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "RoomId",
                principalSchema: "HotelManagementSystem",
                principalTable: "Room",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotel_HotelID",
                schema: "HotelManagementSystem",
                table: "Room",
                column: "HotelID",
                principalSchema: "HotelManagementSystem",
                principalTable: "Hotel",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDetail_Room_RoomId",
                schema: "HotelManagementSystem",
                table: "RoomDetail",
                column: "RoomId",
                principalSchema: "HotelManagementSystem",
                principalTable: "Room",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelDetail_Hotel_HotelID",
                schema: "HotelManagementSystem",
                table: "HotelDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Guest_GuestID",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Room_RoomId",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotel_HotelID",
                schema: "HotelManagementSystem",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDetail_Room_RoomId",
                schema: "HotelManagementSystem",
                table: "RoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_RoomDetail_RoomId",
                schema: "HotelManagementSystem",
                table: "RoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_Room_HotelID",
                schema: "HotelManagementSystem",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_GuestID",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_RoomId",
                schema: "HotelManagementSystem",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_HotelDetail_HotelID",
                schema: "HotelManagementSystem",
                table: "HotelDetail");

            migrationBuilder.AddColumn<int>(
                name: "RoomRef",
                schema: "HotelManagementSystem",
                table: "RoomDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelRef",
                schema: "HotelManagementSystem",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuestRef",
                schema: "HotelManagementSystem",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomRef",
                schema: "HotelManagementSystem",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelRef",
                schema: "HotelManagementSystem",
                table: "HotelDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetail_RoomRef",
                schema: "HotelManagementSystem",
                table: "RoomDetail",
                column: "RoomRef");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelRef",
                schema: "HotelManagementSystem",
                table: "Room",
                column: "HotelRef");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_GuestRef",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "GuestRef");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RoomRef",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "RoomRef");

            migrationBuilder.CreateIndex(
                name: "IX_HotelDetail_HotelRef",
                schema: "HotelManagementSystem",
                table: "HotelDetail",
                column: "HotelRef");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelDetail_Hotel_HotelRef",
                schema: "HotelManagementSystem",
                table: "HotelDetail",
                column: "HotelRef",
                principalSchema: "HotelManagementSystem",
                principalTable: "Hotel",
                principalColumn: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Guest_GuestRef",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "GuestRef",
                principalSchema: "HotelManagementSystem",
                principalTable: "Guest",
                principalColumn: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Room_RoomRef",
                schema: "HotelManagementSystem",
                table: "Reservation",
                column: "RoomRef",
                principalSchema: "HotelManagementSystem",
                principalTable: "Room",
                principalColumn: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotel_HotelRef",
                schema: "HotelManagementSystem",
                table: "Room",
                column: "HotelRef",
                principalSchema: "HotelManagementSystem",
                principalTable: "Hotel",
                principalColumn: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDetail_Room_RoomRef",
                schema: "HotelManagementSystem",
                table: "RoomDetail",
                column: "RoomRef",
                principalSchema: "HotelManagementSystem",
                principalTable: "Room",
                principalColumn: "RoomId");
        }
    }
}

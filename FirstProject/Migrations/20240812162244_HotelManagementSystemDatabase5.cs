using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstProject.Migrations
{
    /// <inheritdoc />
    public partial class HotelManagementSystemDatabase5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HotelManagementSystem");

            migrationBuilder.CreateTable(
                name: "Guest",
                schema: "HotelManagementSystem",
                columns: table => new
                {
                    GuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestAddess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestId);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                schema: "HotelManagementSystem",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelDetail",
                schema: "HotelManagementSystem",
                columns: table => new
                {
                    HotelDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    HotelRef = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelDetail", x => x.HotelDetailID);
                    table.ForeignKey(
                        name: "FK_HotelDetail_Hotel_HotelRef",
                        column: x => x.HotelRef,
                        principalSchema: "HotelManagementSystem",
                        principalTable: "Hotel",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "Room",
                schema: "HotelManagementSystem",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RoomImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    HotelRef = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelRef",
                        column: x => x.HotelRef,
                        principalSchema: "HotelManagementSystem",
                        principalTable: "Hotel",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                schema: "HotelManagementSystem",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ReservationStatus = table.Column<bool>(type: "bit", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    GuestID = table.Column<int>(type: "int", nullable: false),
                    GuestRef = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    RoomRef = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Guest_GuestRef",
                        column: x => x.GuestRef,
                        principalSchema: "HotelManagementSystem",
                        principalTable: "Guest",
                        principalColumn: "GuestId");
                    table.ForeignKey(
                        name: "FK_Reservation_Room_RoomRef",
                        column: x => x.RoomRef,
                        principalSchema: "HotelManagementSystem",
                        principalTable: "Room",
                        principalColumn: "RoomId");
                });

            migrationBuilder.CreateTable(
                name: "RoomDetail",
                schema: "HotelManagementSystem",
                columns: table => new
                {
                    RoomDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomDetailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomDetailCount = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    RoomRef = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomDetail", x => x.RoomDetailId);
                    table.ForeignKey(
                        name: "FK_RoomDetail_Room_RoomRef",
                        column: x => x.RoomRef,
                        principalSchema: "HotelManagementSystem",
                        principalTable: "Room",
                        principalColumn: "RoomId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelDetail_HotelRef",
                schema: "HotelManagementSystem",
                table: "HotelDetail",
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
                name: "IX_Room_HotelRef",
                schema: "HotelManagementSystem",
                table: "Room",
                column: "HotelRef");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetail_RoomRef",
                schema: "HotelManagementSystem",
                table: "RoomDetail",
                column: "RoomRef");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelDetail",
                schema: "HotelManagementSystem");

            migrationBuilder.DropTable(
                name: "Reservation",
                schema: "HotelManagementSystem");

            migrationBuilder.DropTable(
                name: "RoomDetail",
                schema: "HotelManagementSystem");

            migrationBuilder.DropTable(
                name: "Guest",
                schema: "HotelManagementSystem");

            migrationBuilder.DropTable(
                name: "Room",
                schema: "HotelManagementSystem");

            migrationBuilder.DropTable(
                name: "Hotel",
                schema: "HotelManagementSystem");
        }
    }
}

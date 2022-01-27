using Microsoft.EntityFrameworkCore.Migrations;

namespace ZavrsniRad.RezervacijeTermina.Data.Migrations
{
    public partial class ModelsV21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationEvents_AspNetUsers_UserId",
                table: "ReservationEvents");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ReservationEvents",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationEvents_AspNetUsers_UserId",
                table: "ReservationEvents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationEvents_AspNetUsers_UserId",
                table: "ReservationEvents");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ReservationEvents",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationEvents_AspNetUsers_UserId",
                table: "ReservationEvents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

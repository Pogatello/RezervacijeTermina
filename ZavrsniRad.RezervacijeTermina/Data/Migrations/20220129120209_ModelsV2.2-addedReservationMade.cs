using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZavrsniRad.RezervacijeTermina.Data.Migrations
{
    public partial class ModelsV22addedReservationMade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ReservationMade",
                table: "ReservationPeriods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationMadeAt",
                table: "ReservationPeriods",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationMade",
                table: "ReservationPeriods");

            migrationBuilder.DropColumn(
                name: "ReservationMadeAt",
                table: "ReservationPeriods");
        }
    }
}

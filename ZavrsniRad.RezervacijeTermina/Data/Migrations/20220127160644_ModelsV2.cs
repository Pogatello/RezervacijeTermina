﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ZavrsniRad.RezervacijeTermina.Data.Migrations
{
    public partial class ModelsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationDurationType",
                table: "ReservationEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDurationType",
                table: "ReservationEvents");
        }
    }
}

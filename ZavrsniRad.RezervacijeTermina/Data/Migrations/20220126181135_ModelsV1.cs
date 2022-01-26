using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZavrsniRad.RezervacijeTermina.Data.Migrations
{
    public partial class ModelsV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttachmentLogo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentLogo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationEvents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CanUserMakeReservation = table.Column<bool>(type: "bit", nullable: false),
                    IsReservationConfirmationNeeded = table.Column<bool>(type: "bit", nullable: false),
                    AttachmentLogoId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationEvents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservationEvents_AttachmentLogo_AttachmentLogoId",
                        column: x => x.AttachmentLogoId,
                        principalTable: "AttachmentLogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationPeriods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    ReservationPeriodType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReservationEventId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationPeriods_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservationPeriods_ReservationEvents_ReservationEventId",
                        column: x => x.ReservationEventId,
                        principalTable: "ReservationEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationEvents_AttachmentLogoId",
                table: "ReservationEvents",
                column: "AttachmentLogoId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationEvents_UserId",
                table: "ReservationEvents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationPeriods_ReservationEventId",
                table: "ReservationPeriods",
                column: "ReservationEventId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationPeriods_UserId",
                table: "ReservationPeriods",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationPeriods");

            migrationBuilder.DropTable(
                name: "ReservationEvents");

            migrationBuilder.DropTable(
                name: "AttachmentLogo");
        }
    }
}

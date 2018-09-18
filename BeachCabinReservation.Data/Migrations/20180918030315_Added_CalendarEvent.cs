using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeachCabinReservation.Data.Migrations
{
    public partial class Added_CalendarEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LogEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 17, 20, 3, 15, 571, DateTimeKind.Local), new DateTime(2018, 9, 17, 20, 3, 15, 573, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "LogEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 16, 16, 41, 46, 43, DateTimeKind.Local), new DateTime(2018, 9, 16, 16, 41, 46, 45, DateTimeKind.Local) });
        }
    }
}

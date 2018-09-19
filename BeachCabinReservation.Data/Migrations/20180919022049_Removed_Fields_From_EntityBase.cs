using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeachCabinReservation.Data.Migrations
{
    public partial class Removed_Fields_From_EntityBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LogEntries");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LogEntries");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CalendarEvents");

            migrationBuilder.UpdateData(
                table: "LogEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 18, 19, 20, 48, 967, DateTimeKind.Local), new DateTime(2018, 9, 18, 19, 20, 48, 968, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LogEntries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "LogEntries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CalendarEvents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CalendarEvents",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LogEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2018, 9, 18, 19, 5, 40, 317, DateTimeKind.Local), "test", new DateTime(2018, 9, 18, 19, 5, 40, 319, DateTimeKind.Local), "test" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeachCabinReservation.Data.Migrations
{
    public partial class Add_WaitList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalendarEventId",
                table: "CalendarEvents",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsWaitListEvent",
                table: "CalendarEvents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "LogEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 18, 19, 27, 25, 624, DateTimeKind.Local), new DateTime(2018, 9, 18, 19, 27, 25, 626, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEvents_CalendarEventId",
                table: "CalendarEvents",
                column: "CalendarEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalendarEvents_CalendarEvents_CalendarEventId",
                table: "CalendarEvents",
                column: "CalendarEventId",
                principalTable: "CalendarEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalendarEvents_CalendarEvents_CalendarEventId",
                table: "CalendarEvents");

            migrationBuilder.DropIndex(
                name: "IX_CalendarEvents_CalendarEventId",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "CalendarEventId",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "IsWaitListEvent",
                table: "CalendarEvents");

            migrationBuilder.UpdateData(
                table: "LogEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 18, 19, 20, 48, 967, DateTimeKind.Local), new DateTime(2018, 9, 18, 19, 20, 48, 968, DateTimeKind.Local) });
        }
    }
}

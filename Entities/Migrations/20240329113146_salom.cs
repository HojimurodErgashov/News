using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class salom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(6)",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("36929717-b202-479b-aa74-6cf59e59cadf"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 3, 29, 16, 31, 45, 925, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("80f7f49b-e5f2-4248-ab3a-349da4390553"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 3, 29, 16, 31, 45, 925, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 5, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "character varying(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("36929717-b202-479b-aa74-6cf59e59cadf"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 3, 29, 10, 24, 16, 391, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("80f7f49b-e5f2-4248-ab3a-349da4390553"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 3, 29, 10, 24, 16, 391, DateTimeKind.Unspecified).AddTicks(6618), new TimeSpan(0, 5, 0, 0, 0)));
        }
    }
}

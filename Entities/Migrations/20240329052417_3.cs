using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "User");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "User",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("36929717-b202-479b-aa74-6cf59e59cadf"),
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 29, 9, 14, 5, 989, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 5, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("80f7f49b-e5f2-4248-ab3a-349da4390553"),
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 29, 9, 14, 5, 989, DateTimeKind.Unspecified).AddTicks(7391), new TimeSpan(0, 5, 0, 0, 0)), false });
        }
    }
}

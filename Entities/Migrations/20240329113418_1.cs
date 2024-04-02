using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("36929717-b202-479b-aa74-6cf59e59cadf"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 29, 16, 34, 17, 126, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 5, 0, 0, 0)), "c6bd2f4bb77b2712314e8cf4ff3af0528e1145f886131eefa26d3952cced2006" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("80f7f49b-e5f2-4248-ab3a-349da4390553"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 3, 29, 16, 34, 17, 126, DateTimeKind.Unspecified).AddTicks(2524), new TimeSpan(0, 5, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("36929717-b202-479b-aa74-6cf59e59cadf"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 29, 16, 31, 45, 925, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 5, 0, 0, 0)), "333221" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "userId",
                keyValue: new Guid("80f7f49b-e5f2-4248-ab3a-349da4390553"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 3, 29, 16, 31, 45, 925, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 5, 0, 0, 0)));
        }
    }
}

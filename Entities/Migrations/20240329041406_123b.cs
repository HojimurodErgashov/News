using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class _123b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Roles = table.Column<int[]>(type: "integer[]", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userId);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "userId", "CreatedAt", "Email", "FirstName", "Image", "IsActive", "IsDeleted", "LastName", "Password", "Roles", "Token", "UserName" },
                values: new object[,]
                {
                    { new Guid("36929717-b202-479b-aa74-6cf59e59cadf"), new DateTimeOffset(new DateTime(2024, 3, 29, 9, 14, 5, 989, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 5, 0, 0, 0)), "allajanovyakub@gmail.com", "Nodirxon", null, true, false, "Nabixonov", "333221", new[] { 2 }, null, "alikk123" },
                    { new Guid("80f7f49b-e5f2-4248-ab3a-349da4390553"), new DateTimeOffset(new DateTime(2024, 3, 29, 9, 14, 5, 989, DateTimeKind.Unspecified).AddTicks(7391), new TimeSpan(0, 5, 0, 0, 0)), "ergashovhojimurod4@gmail.com", "Hojimurod", null, true, false, "Ergashov", "122333", new[] { 1, 2, 3 }, null, "salom123" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

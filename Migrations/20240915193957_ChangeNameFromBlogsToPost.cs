using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAspMvcPost.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameFromBlogsToPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 9, 16, 2, 39, 56, 301, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 9, 16, 2, 39, 56, 301, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 9, 16, 2, 39, 56, 301, DateTimeKind.Local).AddTicks(9481));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 9, 16, 1, 4, 6, 402, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 9, 16, 1, 4, 6, 402, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 9, 16, 1, 4, 6, 402, DateTimeKind.Local).AddTicks(6060));
        }
    }
}

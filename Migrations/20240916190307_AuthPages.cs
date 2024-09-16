using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAspMvcPost.Migrations
{
    /// <inheritdoc />
    public partial class AuthPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbb877fb-cc4e-4f74-938d-37ee951460d4", "AQAAAAIAAYagAAAAEHEfy8G8XBIttckNNOVY0iuihxeGkVP6vQ7AQunGfw3JCh6M8hYjdAUY7sQX3qE+3Q==" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 9, 17, 2, 3, 5, 979, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 9, 17, 2, 3, 5, 979, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 9, 17, 2, 3, 5, 979, DateTimeKind.Local).AddTicks(7248));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09decb5c-0c97-4d4b-b568-42cca9d493c7", "AQAAAAIAAYagAAAAENVc8ohVzhusctLNiabuWO154NgitKmnZ/XSY9se+yD+rk+DAtnXXx4BTlQrUfo+7w==" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 9, 17, 1, 38, 45, 161, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 9, 17, 1, 38, 45, 161, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 9, 17, 1, 38, 45, 161, DateTimeKind.Local).AddTicks(5395));
        }
    }
}

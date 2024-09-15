using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyAspMvcBlog.Migrations
{
    /// <inheritdoc />
    public partial class BlogSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "blogs",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is my first blog", "My first blog" },
                    { 2, "This is my second blog", "My second blog" },
                    { 3, "This is my third blog", "My third blog" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogs");
        }
    }
}

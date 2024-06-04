using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moviegram.Migrations
{
    /// <inheritdoc />
    public partial class addingquotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoviePostQuote",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoviePostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePostQuote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoviePostQuote_MoviePosts_MoviePostId",
                        column: x => x.MoviePostId,
                        principalTable: "MoviePosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb61761-258a-4463-a926-7d5dec16b0f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dfdbbc2-59a4-4769-8782-5ee2d3534246", "AQAAAAIAAYagAAAAEC3xM8DAnA+kWk1PYbhsujVIRnoxPj5ZPyir65QNkGnkpUlDYBno1Jwm3X8PQ0GY9g==", "06f5b94d-171b-457f-b618-ab19bec95590" });

            migrationBuilder.CreateIndex(
                name: "IX_MoviePostQuote_MoviePostId",
                table: "MoviePostQuote",
                column: "MoviePostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviePostQuote");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb61761-258a-4463-a926-7d5dec16b0f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5595648a-1192-46be-a28b-3c8f3d13cf8a", "AQAAAAIAAYagAAAAEParIktBUv3OJELa+ovPitQVOqAfqWv8r2/aAQHFaRaVzRvswQA886Ujg0Q6XDPcYg==", "1d587fb5-84f5-4d8c-a999-39d49360f5f0" });
        }
    }
}

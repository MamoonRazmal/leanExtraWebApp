using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace leanExtraWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ServerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityPicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ServerId);
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "ServerId", "City", "CityPicture", "IsOnline", "Name" },
                values: new object[,]
                {
                    { 1, "Toronto", null, true, "Server1" },
                    { 2, "Toronto", null, true, "Server2" },
                    { 3, "Toronto", null, true, "Server3" },
                    { 4, "Montreal", null, true, "Server4" },
                    { 5, "Montreal", null, true, "Server5" },
                    { 6, "Ottawa", null, true, "Server6" },
                    { 7, "Ottawa", null, true, "Server7" },
                    { 8, "Calgary", null, true, "Server8" },
                    { 9, "Calgary", null, false, "Server9" },
                    { 10, "Halifax", null, false, "Server10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}

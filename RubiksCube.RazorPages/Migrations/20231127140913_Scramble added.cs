using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubiksCube.RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class Scrambleadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cubes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CubeJson = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cubes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scrambles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Scramble = table.Column<string>(type: "TEXT", nullable: false),
                    CubeId = table.Column<int>(type: "INTEGER", nullable: false),
                    SpeedCuberId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scrambles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scrambles_AspNetUsers_SpeedCuberId",
                        column: x => x.SpeedCuberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Scrambles_Cubes_CubeId",
                        column: x => x.CubeId,
                        principalTable: "Cubes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scrambles_CubeId",
                table: "Scrambles",
                column: "CubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Scrambles_SpeedCuberId",
                table: "Scrambles",
                column: "SpeedCuberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scrambles");

            migrationBuilder.DropTable(
                name: "Cubes");
        }
    }
}

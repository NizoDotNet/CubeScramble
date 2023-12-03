using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubiksCube.RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class RemoveedCubeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scrambles_Cubes_CubeId",
                table: "Scrambles");

            migrationBuilder.DropTable(
                name: "Cubes");

            migrationBuilder.DropIndex(
                name: "IX_Scrambles_CubeId",
                table: "Scrambles");

            migrationBuilder.DropColumn(
                name: "CubeId",
                table: "Scrambles");

            migrationBuilder.AddColumn<string>(
                name: "CubeJson",
                table: "Scrambles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CubeJson",
                table: "Scrambles");

            migrationBuilder.AddColumn<int>(
                name: "CubeId",
                table: "Scrambles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Scrambles_CubeId",
                table: "Scrambles",
                column: "CubeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scrambles_Cubes_CubeId",
                table: "Scrambles",
                column: "CubeId",
                principalTable: "Cubes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

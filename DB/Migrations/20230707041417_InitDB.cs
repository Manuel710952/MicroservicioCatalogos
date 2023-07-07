using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_AREAS",
                columns: table => new
                {
                    Id_area = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_AREAS", x => x.Id_area);
                });

            migrationBuilder.CreateTable(
                name: "T_DOCUMENTOS",
                columns: table => new
                {
                    Id_documento = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_area = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DOCUMENTOS", x => x.Id_documento);
                    table.ForeignKey(
                        name: "FK_T_DOCUMENTOS_T_AREAS_Id_area",
                        column: x => x.Id_area,
                        principalTable: "T_AREAS",
                        principalColumn: "Id_area",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_DOCUMENTOS_Id_area",
                table: "T_DOCUMENTOS",
                column: "Id_area");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_DOCUMENTOS");

            migrationBuilder.DropTable(
                name: "T_AREAS");
        }
    }
}

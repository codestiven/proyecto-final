using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_final.Migrations
{
    /// <inheritdoc />
    public partial class fwone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "examenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    pregunta1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pregunta2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pregunta3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    respuesta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examenes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "examenes");
        }
    }
}

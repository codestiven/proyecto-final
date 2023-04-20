using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_final.Migrations
{
    /// <inheritdoc />
    public partial class fwone8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "respuesta",
                table: "examenes",
                newName: "codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "examenes",
                newName: "respuesta");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_final.Migrations
{
    /// <inheritdoc />
    public partial class koko : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_profesores",
                table: "profesores");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "profesores");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "profesores");

            migrationBuilder.DropColumn(
                name: "Materia",
                table: "profesores");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "profesores");

            migrationBuilder.RenameTable(
                name: "profesores",
                newName: "profesors");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "profesors",
                newName: "contraseña");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "profesors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_profesors",
                table: "profesors",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_profesors",
                table: "profesors");

            migrationBuilder.RenameTable(
                name: "profesors",
                newName: "profesores");

            migrationBuilder.RenameColumn(
                name: "contraseña",
                table: "profesores",
                newName: "Contraseña");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "profesores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "profesores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "profesores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Materia",
                table: "profesores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "profesores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_profesores",
                table: "profesores",
                column: "Id");
        }
    }
}

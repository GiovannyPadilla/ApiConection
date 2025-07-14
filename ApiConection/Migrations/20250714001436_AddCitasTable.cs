using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiConection.Migrations
{
    /// <inheritdoc />
    public partial class AddCitasTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreDueño = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeterinarioAsignado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");
        }
    }
}

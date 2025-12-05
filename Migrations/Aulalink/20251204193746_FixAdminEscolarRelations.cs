using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppJZ.Migrations.Aulalink
{
    /// <inheritdoc />
    public partial class FixAdminEscolarRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "administracionescolar_ibfk_1",
                table: "administracionescolar");

            migrationBuilder.DropForeignKey(
                name: "administracionescolar_ibfk_3",
                table: "administracionescolar");

            migrationBuilder.DropForeignKey(
                name: "datosadicionales_ibfk_1",
                table: "datosadicionales");

            migrationBuilder.DropForeignKey(
                name: "observadoralumno_ibfk_2",
                table: "observadoralumno");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "usuario",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "usuario",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "usuario",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_general_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DocenteNavigationId",
                table: "observadoralumno",
                type: "int(11)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "datosadicionales",
                type: "int(11)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_observadoralumno_DocenteNavigationId",
                table: "observadoralumno",
                column: "DocenteNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_datosadicionales_UsuarioId1",
                table: "datosadicionales",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_administracionescolar_usuario_docente_id",
                table: "administracionescolar",
                column: "docente_id",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "administracionescolar_ibfk_3",
                table: "administracionescolar",
                column: "estudiante_id",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_datosadicionales_usuario_UsuarioId1",
                table: "datosadicionales",
                column: "UsuarioId1",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_observadoralumno_usuario_DocenteNavigationId",
                table: "observadoralumno",
                column: "DocenteNavigationId",
                principalTable: "usuario",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_administracionescolar_usuario_docente_id",
                table: "administracionescolar");

            migrationBuilder.DropForeignKey(
                name: "administracionescolar_ibfk_3",
                table: "administracionescolar");

            migrationBuilder.DropForeignKey(
                name: "FK_datosadicionales_usuario_UsuarioId1",
                table: "datosadicionales");

            migrationBuilder.DropForeignKey(
                name: "FK_observadoralumno_usuario_DocenteNavigationId",
                table: "observadoralumno");

            migrationBuilder.DropIndex(
                name: "IX_observadoralumno_DocenteNavigationId",
                table: "observadoralumno");

            migrationBuilder.DropIndex(
                name: "IX_datosadicionales_UsuarioId1",
                table: "datosadicionales");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "DocenteNavigationId",
                table: "observadoralumno");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "datosadicionales");

            migrationBuilder.AddForeignKey(
                name: "administracionescolar_ibfk_1",
                table: "administracionescolar",
                column: "docente_id",
                principalTable: "usuario",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "administracionescolar_ibfk_3",
                table: "administracionescolar",
                column: "estudiante_id",
                principalTable: "usuario",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "datosadicionales_ibfk_1",
                table: "datosadicionales",
                column: "usuario_id",
                principalTable: "usuario",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "observadoralumno_ibfk_2",
                table: "observadoralumno",
                column: "docente",
                principalTable: "usuario",
                principalColumn: "id");
        }
    }
}

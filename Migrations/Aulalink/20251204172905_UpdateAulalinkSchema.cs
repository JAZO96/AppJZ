using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppJZ.Migrations.Aulalink
{
    /// <inheritdoc />
    public partial class UpdateAulalinkSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "__efmigrationshistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductVersion = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.MigrationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "docente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "materia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "parentesco",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "periodoacademico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tipoactividad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tipodocumento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tipodocumentoacademico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tipomaterial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "grado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Creditos = table.Column<int>(type: "int(11)", nullable: true),
                    Nivel = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocenteId = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "grado_ibfk_docente",
                        column: x => x.DocenteId,
                        principalTable: "docente",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "formulario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_documento_id = table.Column<int>(type: "int(11)", nullable: false),
                    numero_documento = table.Column<int>(type: "int(11)", nullable: false),
                    nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rol_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "formulario_ibfk_1",
                        column: x => x.tipo_documento_id,
                        principalTable: "tipodocumento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "formulario_ibfk_2",
                        column: x => x.rol_id,
                        principalTable: "rol",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_documento_id = table.Column<int>(type: "int(11)", nullable: false),
                    numero_documento = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contraseña = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rol_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "usuario_ibfk_1",
                        column: x => x.tipo_documento_id,
                        principalTable: "tipodocumento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "usuario_ibfk_2",
                        column: x => x.rol_id,
                        principalTable: "rol",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "bibliotecaalmacen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_material_id = table.Column<int>(type: "int(11)", nullable: true),
                    nombre_material = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    disponible = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    cantidad = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "bibliotecaalmacen_ibfk_1",
                        column: x => x.tipo_material_id,
                        principalTable: "tipomaterial",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "gradomateria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    grado_id = table.Column<int>(type: "int(11)", nullable: false),
                    materia_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "gradomateria_ibfk_1",
                        column: x => x.grado_id,
                        principalTable: "grado",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "gradomateria_ibfk_2",
                        column: x => x.materia_id,
                        principalTable: "materia",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "actividadevaluacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_actividad_id = table.Column<int>(type: "int(11)", nullable: true),
                    descripcion = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    usuario_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "actividadevaluacion_ibfk_1",
                        column: x => x.tipo_actividad_id,
                        principalTable: "tipoactividad",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "actividadevaluacion_ibfk_2",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "administracionescolar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    docente_id = table.Column<int>(type: "int(11)", nullable: true),
                    grado_id = table.Column<int>(type: "int(11)", nullable: true),
                    estudiante_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "administracionescolar_ibfk_1",
                        column: x => x.docente_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "administracionescolar_ibfk_2",
                        column: x => x.grado_id,
                        principalTable: "grado",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "administracionescolar_ibfk_3",
                        column: x => x.estudiante_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "datosadicionales",
                columns: table => new
                {
                    usuario_id = table.Column<int>(type: "int(11)", nullable: false),
                    direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grado = table.Column<int>(type: "int(20)", nullable: true),
                    nombre_acudiente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero_acudiente = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    parentesco_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.usuario_id);
                    table.ForeignKey(
                        name: "datosadicionales_ibfk_1",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "datosadicionales_ibfk_2",
                        column: x => x.parentesco_id,
                        principalTable: "parentesco",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "datosadicionales_ibfk_3",
                        column: x => x.grado,
                        principalTable: "grado",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "documentacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_documento_id = table.Column<int>(type: "int(11)", nullable: true),
                    descripcion = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    usuario_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "documentacion_ibfk_1",
                        column: x => x.tipo_documento_id,
                        principalTable: "tipodocumentoacademico",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "documentacion_ibfk_2",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "gestionacademica",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario_id = table.Column<int>(type: "int(11)", nullable: true),
                    registrar_actividades = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grupos_trabajo = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "gestionacademica_ibfk_1",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "matriculafinanzas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario_id = table.Column<int>(type: "int(11)", nullable: true),
                    matricula = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    pension = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    fecha_pago = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "matriculafinanzas_ibfk_1",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "observadoralumno",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario_id = table.Column<int>(type: "int(11)", nullable: true),
                    fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    observaciones = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docente = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "observadoralumno_ibfk_1",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "observadoralumno_ibfk_2",
                        column: x => x.docente,
                        principalTable: "usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateIndex(
                name: "tipo_actividad_id",
                table: "actividadevaluacion",
                column: "tipo_actividad_id");

            migrationBuilder.CreateIndex(
                name: "usuario_id",
                table: "actividadevaluacion",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "docente_id",
                table: "administracionescolar",
                column: "docente_id");

            migrationBuilder.CreateIndex(
                name: "estudiante_id",
                table: "administracionescolar",
                column: "estudiante_id");

            migrationBuilder.CreateIndex(
                name: "grado_id",
                table: "administracionescolar",
                column: "grado_id");

            migrationBuilder.CreateIndex(
                name: "tipo_material_id",
                table: "bibliotecaalmacen",
                column: "tipo_material_id");

            migrationBuilder.CreateIndex(
                name: "grado",
                table: "datosadicionales",
                column: "grado");

            migrationBuilder.CreateIndex(
                name: "parentesco_id",
                table: "datosadicionales",
                column: "parentesco_id");

            migrationBuilder.CreateIndex(
                name: "tipo_documento_id",
                table: "documentacion",
                column: "tipo_documento_id");

            migrationBuilder.CreateIndex(
                name: "usuario_id1",
                table: "documentacion",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "rol_id",
                table: "formulario",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "tipo_documento_id1",
                table: "formulario",
                column: "tipo_documento_id");

            migrationBuilder.CreateIndex(
                name: "usuario_id2",
                table: "gestionacademica",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_grado_DocenteId",
                table: "grado",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "grado_id1",
                table: "gradomateria",
                columns: new[] { "grado_id", "materia_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "materia_id",
                table: "gradomateria",
                column: "materia_id");

            migrationBuilder.CreateIndex(
                name: "usuario_id3",
                table: "matriculafinanzas",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "docente",
                table: "observadoralumno",
                column: "docente");

            migrationBuilder.CreateIndex(
                name: "usuario_id4",
                table: "observadoralumno",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "numero_documento",
                table: "usuario",
                column: "numero_documento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "rol_id1",
                table: "usuario",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "tipo_documento_id2",
                table: "usuario",
                column: "tipo_documento_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__efmigrationshistory");

            migrationBuilder.DropTable(
                name: "actividadevaluacion");

            migrationBuilder.DropTable(
                name: "administracionescolar");

            migrationBuilder.DropTable(
                name: "bibliotecaalmacen");

            migrationBuilder.DropTable(
                name: "datosadicionales");

            migrationBuilder.DropTable(
                name: "documentacion");

            migrationBuilder.DropTable(
                name: "formulario");

            migrationBuilder.DropTable(
                name: "gestionacademica");

            migrationBuilder.DropTable(
                name: "gradomateria");

            migrationBuilder.DropTable(
                name: "matriculafinanzas");

            migrationBuilder.DropTable(
                name: "observadoralumno");

            migrationBuilder.DropTable(
                name: "periodoacademico");

            migrationBuilder.DropTable(
                name: "tipoactividad");

            migrationBuilder.DropTable(
                name: "tipomaterial");

            migrationBuilder.DropTable(
                name: "parentesco");

            migrationBuilder.DropTable(
                name: "tipodocumentoacademico");

            migrationBuilder.DropTable(
                name: "grado");

            migrationBuilder.DropTable(
                name: "materia");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "docente");

            migrationBuilder.DropTable(
                name: "tipodocumento");

            migrationBuilder.DropTable(
                name: "rol");
        }
    }
}

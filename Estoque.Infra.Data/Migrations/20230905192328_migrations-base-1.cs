using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class migrationsbase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    IdFilial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodFilial = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    DescFilial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsMatriz = table.Column<bool>(type: "bit", nullable: false),
                    InseridoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InseridoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.IdFilial);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    IdTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescTipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InseridoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InseridoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.IdTipo);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodItem = table.Column<int>(type: "int", nullable: false),
                    DescItem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantidade = table.Column<long>(type: "bigint", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InseridoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InseridoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IdFilial = table.Column<int>(type: "int", nullable: false),
                    IdTipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_Itens_Filiais_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itens_Tipos_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Tipos",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_IdFilial",
                table: "Itens",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_IdTipo",
                table: "Itens",
                column: "IdTipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}

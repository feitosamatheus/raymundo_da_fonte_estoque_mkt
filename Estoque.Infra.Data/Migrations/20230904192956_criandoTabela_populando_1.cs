using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class criandoTabela_populando_1 : Migration
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
                    IsFilial = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Items",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodItem = table.Column<int>(type: "int", nullable: false),
                    IdFilial = table.Column<int>(type: "int", nullable: false),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    DescItem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantidade = table.Column<long>(type: "bigint", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InseridoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InseridoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    FilialIdIdFilial = table.Column<int>(type: "int", nullable: true),
                    TipoIdIdTipo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_Items_Filiais_FilialIdIdFilial",
                        column: x => x.FilialIdIdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial");
                    table.ForeignKey(
                        name: "FK_Items_Tipos_TipoIdIdTipo",
                        column: x => x.TipoIdIdTipo,
                        principalTable: "Tipos",
                        principalColumn: "IdTipo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_FilialIdIdFilial",
                table: "Items",
                column: "FilialIdIdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TipoIdIdTipo",
                table: "Items",
                column: "TipoIdIdTipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}

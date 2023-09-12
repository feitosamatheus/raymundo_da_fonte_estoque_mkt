using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class migrationbasePEDIDOS2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DescTipo",
                table: "Tipos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DescFilial",
                table: "Filiais",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
     

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPedido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QtdPedida = table.Column<int>(type: "int", nullable: false),
                    QtdAtendida = table.Column<int>(type: "int", nullable: false),
                    NotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdItem = table.Column<int>(type: "int", nullable: false),
                    IdSituacao = table.Column<int>(type: "int", nullable: false),
                    DataPedido = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFaturamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFinalizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Itens_IdItem",
                        column: x => x.IdItem,
                        principalTable: "Itens",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_SituacaoPedido_IdSituacao",
                        column: x => x.IdSituacao,
                        principalTable: "SituacaoPedido",
                        principalColumn: "IdSituacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdCliente",
                table: "Pedidos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdItem",
                table: "Pedidos",
                column: "IdItem");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdSituacao",
                table: "Pedidos",
                column: "IdSituacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.AlterColumn<string>(
                name: "DescTipo",
                table: "Tipos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescFilial",
                table: "Filiais",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

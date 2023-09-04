using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class popularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Filiais(CodFilial, DescFilial, IsFilial, Status, InseridoPor, InseridoEm) " +
                "VALUES(102,'Salvador',0,1,'54321','2023-09-04')");

            migrationBuilder.Sql("INSERT INTO Filiais(CodFilial, DescFilial, IsFilial, Status, InseridoPor, InseridoEm) " +
                "VALUES(104,'Matriz',1,1,'54321','2023-09-04')");

            migrationBuilder.Sql("INSERT INTO Tipos(DescTipo, Status, InseridoPor, InseridoEm) " +
                "VALUES('Físico',1,'54321','2023-09-04')");

            migrationBuilder.Sql("INSERT INTO Tipos(DescTipo, Status, InseridoPor, InseridoEm) " +
                "VALUES('Débito',1,'54321','2023-09-04')");


            //        DescTipo = "Físico",
            //        Status = true,
            //        InseridoPor = "54321",
            //        InseridoEm = DateTime.Now
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

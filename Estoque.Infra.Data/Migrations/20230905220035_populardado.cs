using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class populardado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("INSERT INTO Filiais(CodFilial,DescFilial,IsMatriz,InseridoPor,InseridoEm,Status) " +
            //    "VALUES(101,'Matriz Paulista', 1, '54321', '2023-05-09', 1)");

            //migrationBuilder.Sql("INSERT INTO Filiais(CodFilial,DescFilial,IsMatriz,InseridoPor,InseridoEm,Status) " +
            //    "VALUES(102,'Salvador', 0, '54321', '2023-05-09', 1)");

            //migrationBuilder.Sql("INSERT INTO Lanches(CodItem,DescItem,Quantidade,UrlImagem,Observacao,InseridoPor,InseridoEm, Status) " +
            //    "VALUES(9729,'EXP. CARAMBOLA GIRATORIO - MINI', 999, 'https://lh3.googleusercontent.com/JrPy6Vb5JzQtspAgnTHvy3cuf3LU8ufVkah3iEa3osnn6HzUDuo8sSfQ32uEXnc=w600','','54321', '2023-05-09', 1)");


            //migrationBuilder.Sql("INSERT INTO Lanches(CodItem,DescItem,Quantidade,UrlImagem,Observacao,InseridoPor,InseridoEm, Status) " +
            //    "VALUES(47357,'EXP. CARAMBOLA GIRATORIO - PEQ', 998, 'https://lh3.googleusercontent.com/s9K1NpsAXwwMEni0wEuvGMgDgbzqGFF-ikHvKtnD7TPpYbskutxL6QcehfFH6Q=w600','','54321', '2023-05-09', 1)");

            //migrationBuilder.Sql("INSERT INTO Tipos(DescTipo,InseridoPor,InseridoEm,Status) " +
            //    "VALUES('Débito','54321', '2023-05-09', 1)");
            //migrationBuilder.Sql("INSERT INTO Tipos(DescTipo,InseridoPor,InseridoEm,Status) " +
            //    "VALUES('Físico','54321', '2023-05-09', 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class populartbitens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Itens(CodItem,DescItem,Quantidade,UrlImagem,Observacao,InseridoPor,InseridoEm, Status, IdTipo,IdFilial) " +
                "VALUES(9729,'EXP. CARAMBOLA GIRATORIO - MINI', 999, 'https://lh3.googleusercontent.com/JrPy6Vb5JzQtspAgnTHvy3cuf3LU8ufVkah3iEa3osnn6HzUDuo8sSfQ32uEXnc=w600','','54321', '2023-05-09', 1,1,1)");


            migrationBuilder.Sql("INSERT INTO Itens(CodItem,DescItem,Quantidade,UrlImagem,Observacao,InseridoPor,InseridoEm, Status, IdTipo, IdFilial) " +
                "VALUES(47357,'EXP. CARAMBOLA GIRATORIO - PEQ', 998, 'https://lh3.googleusercontent.com/s9K1NpsAXwwMEni0wEuvGMgDgbzqGFF-ikHvKtnD7TPpYbskutxL6QcehfFH6Q=w600','','54321', '2023-05-09', 1,1,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

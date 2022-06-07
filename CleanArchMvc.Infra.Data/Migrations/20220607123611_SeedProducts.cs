using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " + 
                "VALUES('Caderno Espiral', 'Caderno espiral 100 folhas', 7.45, 50, 'caderno.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
                "VALUES('Estojo Escolar', 'Estojo Escolar cinza', 5.65, 70, 'estojo1.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
                "VALUES('Borracha Escolar', 'Borracha Branca Pequena', 3.25, 80, 'borracha1.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
                "VALUES('Calculadora Escolar', 'Calculadora Simples', 15.39, 20, 'calculadora1.jpg', 2)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}

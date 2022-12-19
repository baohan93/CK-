using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
            "VALUES('Milk Tea','Our rich and creamy milk tea is further elevated to the next level when combined with our one-of-a-kind bubbles.')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
            "VALUES('Tea','Don’t let this seemingly gimmicky drink fool you, it’s packed with anti-oxidants from green tea and beneficial probiotics from the popular health drinks brand.')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
            "VALUES('Cake','Don’t let this seemingly gimmicky drink fool you, it’s packed with anti-oxidants from green tea and beneficial probiotics from the popular health drinks brand.')");
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}

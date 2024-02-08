using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Colar", "Colar da Sonserina", "https://nerdstore.com.br/produto/colar-flamula-sonserina/", "Colar Flamula Sonserina", 41.9m },
                    { 2L, "Colar", "Colar da Lufa-Lufa", "https://nerdstore.com.br/wp-content/uploads/2020/11/colar-flamula-lufa-lufa.jpg.webp", "Colar Flamula Lufa-Lufa", 41.9m },
                    { 3L, "Colar", "Colar da Grifinoria", "https://nerdstore.com.br/wp-content/uploads/2020/11/colar-flamula-grifinoria.jpg.webp", "Colar Flamula Grifinoria", 41.9m },
                    { 4L, "Colar", "Colar da Corvinal", "https://nerdstore.com.br/wp-content/uploads/2020/11/colar-flamula-corvinal.jpg.webp", "Colar Flamula Corvinal", 41.9m },
                    { 5L, "Adesivo", "Adesivo Árvore de Gondor", "https://nerdstore.com.br/wp-content/uploads/2023/07/vitrine-adesivo-arvore-de-gondor-02-nerdstore.jpg.webp", "Adesivo Árvore de Gondor", 9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);
        }
    }
}

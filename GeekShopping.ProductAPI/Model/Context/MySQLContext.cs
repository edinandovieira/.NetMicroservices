using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Colar Flamula Sonserina",
                    Price = new decimal(41.90),
                    Description = "Colar da Sonserina",
                    ImageURL = "https://nerdstore.com.br/produto/colar-flamula-sonserina/",
                    CategoryName = "Colar"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 2,
                    Name = "Colar Flamula Lufa-Lufa",
                    Price = new decimal(41.90),
                    Description = "Colar da Lufa-Lufa",
                    ImageURL = "https://nerdstore.com.br/wp-content/uploads/2020/11/colar-flamula-lufa-lufa.jpg.webp",
                    CategoryName = "Colar"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    Name = "Colar Flamula Grifinoria",
                    Price = new decimal(41.90),
                    Description = "Colar da Grifinoria",
                    ImageURL = "https://nerdstore.com.br/wp-content/uploads/2020/11/colar-flamula-grifinoria.jpg.webp",
                    CategoryName = "Colar"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    Name = "Colar Flamula Corvinal",
                    Price = new decimal(41.90),
                    Description = "Colar da Corvinal",
                    ImageURL = "https://nerdstore.com.br/wp-content/uploads/2020/11/colar-flamula-corvinal.jpg.webp",
                    CategoryName = "Colar"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    Name = "Adesivo Árvore de Gondor",
                    Price = new decimal(9.00),
                    Description = "Adesivo Árvore de Gondor",
                    ImageURL = "https://nerdstore.com.br/wp-content/uploads/2023/07/vitrine-adesivo-arvore-de-gondor-02-nerdstore.jpg.webp",
                    CategoryName = "Adesivo"
                });
        }
    }
}

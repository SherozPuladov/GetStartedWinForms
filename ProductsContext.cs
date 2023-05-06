using Microsoft.EntityFrameworkCore;

namespace GetStartedWinForms;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set;}
    public DbSet<Category> Categories { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryID = 1, Name = "Cheese" },
            new Category { CategoryID = 2, Name = "Meat" },
            new Category { CategoryID = 3, Name = "Fish" },
            new Category { CategoryID = 4, Name = "Bread" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductID = 1, CategoryId = 1, Name = "Cheddar" },
            new Product { ProductID = 2, CategoryId = 1, Name = "Brie" },
            new Product { ProductID = 3, CategoryId = 1, Name = "Stilton" },
            new Product { ProductID = 4, CategoryId = 1, Name = "Cheshire" },
            new Product { ProductID = 5, CategoryId = 1, Name = "Swiss" },
            new Product { ProductID = 6, CategoryId = 1, Name = "Gruyere" },
            new Product { ProductID = 7, CategoryId = 1, Name = "Colby" },
            new Product { ProductID = 8, CategoryId = 1, Name = "Mozzela" },
            new Product { ProductID = 9, CategoryId = 1, Name = "Ricotta" },
            new Product { ProductID = 10, CategoryId = 1, Name = "Parmesan" },
            new Product { ProductID = 11, CategoryId = 2, Name = "Ham" },
            new Product { ProductID = 12, CategoryId = 2, Name = "Beef" },
            new Product { ProductID = 13, CategoryId = 2, Name = "Chicken" },
            new Product { ProductID = 14, CategoryId = 2, Name = "Turkey" },
            new Product { ProductID = 15, CategoryId = 2, Name = "Prosciutto" },
            new Product { ProductID = 16, CategoryId = 2, Name = "Bacon" },
            new Product { ProductID = 17, CategoryId = 2, Name = "Mutton" },
            new Product { ProductID = 18, CategoryId = 2, Name = "Pastrami" },
            new Product { ProductID = 19, CategoryId = 2, Name = "Hazlet" },
            new Product { ProductID = 20, CategoryId = 2, Name = "Salami" },
            new Product { ProductID = 21, CategoryId = 3, Name = "Salmon" },
            new Product { ProductID = 22, CategoryId = 3, Name = "Tuna" },
            new Product { ProductID = 23, CategoryId = 3, Name = "Mackerel" },
            new Product { ProductID = 24, CategoryId = 4, Name = "Rye" },
            new Product { ProductID = 25, CategoryId = 4, Name = "Wheat" },
            new Product { ProductID = 26, CategoryId = 4, Name = "Brioche" },
            new Product { ProductID = 27, CategoryId = 4, Name = "Naan" },
            new Product { ProductID = 28, CategoryId = 4, Name = "Focaccia" },
            new Product { ProductID = 29, CategoryId = 4, Name = "Malted" },
            new Product { ProductID = 30, CategoryId = 4, Name = "Sourdough" },
            new Product { ProductID = 31, CategoryId = 4, Name = "Corn" },
            new Product { ProductID = 32, CategoryId = 4, Name = "White" },
            new Product { ProductID = 33, CategoryId = 4, Name = "Soda" });
    }
}

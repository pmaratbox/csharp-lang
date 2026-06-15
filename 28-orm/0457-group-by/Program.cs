using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

var conn = new SqliteConnection("Data Source=:memory:");
conn.Open();
using var db = new AppDb(conn);
db.Database.EnsureCreated();

db.Products.AddRange(
    new Product { Id = 1, Category = "a", Price = 10 },
    new Product { Id = 2, Category = "b", Price = 20 },
    new Product { Id = 3, Category = "a", Price = 30 });
db.SaveChanges();

var groups = db.Products
    .GroupBy(p => p.Category)
    .Select(g => new { Category = g.Key, Sum = g.Sum(p => p.Price) })
    .OrderBy(g => g.Category);

foreach (var g in groups)
    Console.WriteLine($"{g.Category} {g.Sum}");

public class Product
{
    public int Id { get; set; }
    public string Category { get; set; } = "";
    public int Price { get; set; }
}

public class AppDb : DbContext
{
    private readonly SqliteConnection _c;
    public AppDb(SqliteConnection c) { _c = c; }
    public DbSet<Product> Products => Set<Product>();
    protected override void OnConfiguring(DbContextOptionsBuilder o) => o.UseSqlite(_c);
}

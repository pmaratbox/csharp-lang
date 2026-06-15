using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

var conn = new SqliteConnection("Data Source=:memory:");
conn.Open();
using var db = new AppDb(conn);
db.Database.EnsureCreated();

db.Users.AddRange(
    new User { Id = 1, Name = "alice", Age = 30 },
    new User { Id = 2, Name = "bob", Age = 25 },
    new User { Id = 3, Name = "carol", Age = 35 });
db.SaveChanges();

// Load the tracked entity and modify it through the ORM, then persist.
var bob = db.Users.Single(u => u.Name == "bob");
bob.Age = 40;
db.SaveChanges();

foreach (var u in db.Users.Where(u => u.Age >= 35).OrderBy(u => u.Id))
    Console.WriteLine($"{u.Name} {u.Age}");

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

public class AppDb : DbContext
{
    private readonly SqliteConnection _c;
    public AppDb(SqliteConnection c) { _c = c; }
    public DbSet<User> Users => Set<User>();
    protected override void OnConfiguring(DbContextOptionsBuilder o) => o.UseSqlite(_c);
}

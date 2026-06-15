using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

var conn = new SqliteConnection("Data Source=:memory:");
conn.Open();
using var db = new AppDb(conn);
db.Database.EnsureCreated();

db.Users.AddRange(
    new User { Id = 1, Name = "alice" },
    new User { Id = 2, Name = "bob" });
db.Posts.AddRange(
    new Post { Id = 1, UserId = 1, Title = "hello" },
    new Post { Id = 2, UserId = 1, Title = "world" },
    new Post { Id = 3, UserId = 2, Title = "hi" });
db.SaveChanges();

var rows = db.Posts
    .Join(db.Users, p => p.UserId, u => u.Id, (p, u) => new { u.Name, p.Title })
    .OrderBy(r => r.Name).ThenBy(r => r.Title);
foreach (var r in rows) Console.WriteLine($"{r.Name} {r.Title}");

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = "";
}

public class AppDb : DbContext
{
    private readonly SqliteConnection _c;
    public AppDb(SqliteConnection c) { _c = c; }
    public DbSet<User> Users => Set<User>();
    public DbSet<Post> Posts => Set<Post>();
    protected override void OnConfiguring(DbContextOptionsBuilder o) => o.UseSqlite(_c);
}

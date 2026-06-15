using System.Net.Http.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder();
builder.WebHost.UseTestServer();
builder.Logging.ClearProviders();
var app = builder.Build();

app.MapPost("/sum", (Nums n) => n.A + n.B);

await app.StartAsync();
var client = app.GetTestClient();
var resp = await client.PostAsJsonAsync("/sum", new { a = 2, b = 3 });
Console.WriteLine(await resp.Content.ReadAsStringAsync());
await app.StopAsync();

record Nums(int A, int B);

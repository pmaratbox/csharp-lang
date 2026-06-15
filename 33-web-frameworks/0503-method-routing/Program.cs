using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder();
builder.WebHost.UseTestServer();
builder.Logging.ClearProviders();
var app = builder.Build();
app.MapGet("/item", () => "get");
app.MapPost("/item", () => "post");
await app.StartAsync();
var client = app.GetTestClient();
var resp = await client.PostAsync("/item", null);
Console.WriteLine(await resp.Content.ReadAsStringAsync());
await app.StopAsync();

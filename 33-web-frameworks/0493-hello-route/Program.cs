using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder();
builder.WebHost.UseTestServer();
builder.Logging.ClearProviders();
var app = builder.Build();
app.MapGet("/", () => "hello");
await app.StartAsync();
var client = app.GetTestClient();
Console.WriteLine(await client.GetStringAsync("/"));
await app.StopAsync();

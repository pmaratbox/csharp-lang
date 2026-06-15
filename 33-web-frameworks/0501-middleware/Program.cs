using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder();
builder.WebHost.UseTestServer();
builder.Logging.ClearProviders();
var app = builder.Build();

// Middleware: buffer the downstream response body, then prefix it with "[mw] ".
app.Use(async (context, next) =>
{
    var original = context.Response.Body;
    using var buffer = new MemoryStream();
    context.Response.Body = buffer;

    await next();

    buffer.Position = 0;
    var body = await new StreamReader(buffer).ReadToEndAsync();
    context.Response.Body = original;
    await context.Response.WriteAsync("[mw] " + body);
});

app.MapGet("/", () => "hello");

await app.StartAsync();
var client = app.GetTestClient();
Console.WriteLine(await client.GetStringAsync("/"));
await app.StopAsync();

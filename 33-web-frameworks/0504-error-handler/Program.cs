using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder();
builder.WebHost.UseTestServer();
builder.Logging.ClearProviders();
var app = builder.Build();
// The framework's exception handler turns any unhandled exception into a 500.
app.UseExceptionHandler(errApp => errApp.Run(ctx =>
{
    ctx.Response.StatusCode = StatusCodes.Status500InternalServerError;
    return Task.CompletedTask;
}));
app.MapGet("/boom", () => { throw new InvalidOperationException("boom"); });
await app.StartAsync();
var client = app.GetTestClient();
var resp = await client.GetAsync("/boom");
Console.WriteLine((int)resp.StatusCode);
await app.StopAsync();

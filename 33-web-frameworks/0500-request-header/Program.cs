using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder();
builder.WebHost.UseTestServer();
builder.Logging.ClearProviders();
var app = builder.Build();

app.MapGet("/whoami", (HttpRequest req) => req.Headers["X-Name"].ToString());

await app.StartAsync();
var client = app.GetTestClient();

var request = new HttpRequestMessage(HttpMethod.Get, "/whoami");
request.Headers.Add("X-Name", "alice");
var resp = await client.SendAsync(request);
Console.WriteLine(await resp.Content.ReadAsStringAsync());

await app.StopAsync();

// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port).
using System.Net;
using System.Text.Json;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };

var json = await c.GetStringAsync("/user");
var name = JsonDocument.Parse(json).RootElement.GetProperty("name").GetString();
Console.WriteLine(name);

class Stub : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var p = req.RequestUri!.AbsolutePath;
        if (p == "/user")
        {
            var m = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"name\":\"Alice\",\"age\":30}")
            };
            return Task.FromResult(m);
        }
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent("")
        });
    }
}

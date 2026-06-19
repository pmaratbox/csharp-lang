// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port).
using System.Net;
using System.Text;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };
Console.WriteLine((int)(await c.GetAsync("/missing")).StatusCode); // 404

class Stub : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var p = req.RequestUri!.AbsolutePath;
        // This in-process server defines no routes, so every path is unknown -> 404.
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent("", Encoding.UTF8)
        });
    }
}

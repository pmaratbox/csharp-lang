// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port).
using System.Net;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };
var resp = await c.GetAsync("/hello");
Console.WriteLine((int)resp.StatusCode);

class Stub : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var p = req.RequestUri!.AbsolutePath;
        if (p == "/hello")
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("hello world") });
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("") });
    }
}

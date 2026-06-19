using System.Net;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };
var ir = await c.GetAsync("/info");
Console.WriteLine(ir.Headers.GetValues("X-Count").First());

class Stub : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var p = req.RequestUri!.AbsolutePath;
        if (p == "/info")
        {
            var m = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("") };
            m.Headers.TryAddWithoutValidation("X-Count", "7");
            return Task.FromResult(m);
        }
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("") });
    }
}

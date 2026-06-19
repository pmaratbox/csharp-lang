// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port).
// IMPORTANT: top-level statements FIRST, then the Stub class declaration LAST.
using System.Net;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };

var req = new HttpRequestMessage(HttpMethod.Get, "/token");
req.Headers.Add("X-Token", "secret");
var resp = await c.SendAsync(req);
Console.WriteLine(await resp.Content.ReadAsStringAsync());

class Stub : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var p = req.RequestUri!.AbsolutePath;
        if (p == "/token")
        {
            // Echo the request header X-Token back in the body.
            var token = req.Headers.GetValues("X-Token").First();
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(token)
            });
        }
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent("")
        });
    }
}

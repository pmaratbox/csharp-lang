// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port).
using System.Net;

var client = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };
Console.WriteLine(await client.GetStringAsync("/hello"));

class Stub : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var path = req.RequestUri!.AbsolutePath;
        if (path == "/hello")
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("hello world")
            });
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent("")
        });
    }
}

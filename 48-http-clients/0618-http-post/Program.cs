// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port). Run: dotnet run  (DOTNET_NOLOGO=1)
using System.Net;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };

var res = await c.PostAsync("/echo", new StringContent("ping"));
Console.WriteLine(await res.Content.ReadAsStringAsync());

class Stub : HttpMessageHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var p = req.RequestUri!.AbsolutePath;
        if (p == "/echo" && req.Method == HttpMethod.Post)
        {
            var body = await req.Content!.ReadAsStringAsync(ct);
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(body) };
        }
        return new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("") };
    }
}

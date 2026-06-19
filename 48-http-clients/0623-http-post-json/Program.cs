using System.Net;
using System.Text;
using System.Text.Json;

var client = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };

var response = await client.PostAsync("/double", new StringContent("{\"x\":5}", Encoding.UTF8, "application/json"));
var json = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
Console.WriteLine(json.RootElement.GetProperty("doubled").GetInt32());

class Stub : HttpMessageHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var path = req.RequestUri!.AbsolutePath;
        if (path == "/double" && req.Method == HttpMethod.Post)
        {
            var x = JsonDocument.Parse(await req.Content!.ReadAsStringAsync(ct)).RootElement.GetProperty("x").GetInt32();
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent($"{{\"doubled\":{x * 2}}}")
            };
        }
        return new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("") };
    }
}

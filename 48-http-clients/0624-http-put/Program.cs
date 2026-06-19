// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port).
using System.Net;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };
var pr = await c.SendAsync(new HttpRequestMessage(HttpMethod.Put, "/item"));
Console.WriteLine(await pr.Content.ReadAsStringAsync());

class Stub : HttpMessageHandler {
  protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct) {
    var p = req.RequestUri!.AbsolutePath;
    if (p == "/item" && req.Method == HttpMethod.Put)
      return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("updated") });
    return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("") });
  }
}

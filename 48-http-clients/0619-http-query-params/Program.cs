// C# — HttpClient + custom HttpMessageHandler stub (in-process, NO socket/port).
using System.Net;

var c = new HttpClient(new Stub()) { BaseAddress = new Uri("http://test") };
Console.WriteLine(await c.GetStringAsync("/greet?name=Bob"));   // hi Bob

class Stub : HttpMessageHandler {
  protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct) {
    var p = req.RequestUri!.AbsolutePath;
    var q = req.RequestUri!.Query;
    if (p == "/greet") {
      // parse ?name=Bob manually (no System.Web)
      var name = q.TrimStart('?').Split('=')[1];
      return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) {
        Content = new StringContent("hi " + name)
      });
    }
    return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound) {
      Content = new StringContent("")
    });
  }
}

# 0500 — Request header

Uses ASP.NET Core Minimal APIs to expose `GET /whoami`; the handler reads the incoming `X-Name` request header from `HttpRequest.Headers` and echoes its value. The route is exercised in-process through `Microsoft.AspNetCore.TestHost` (`WebHost.UseTestServer()` + `app.GetTestClient()`), sending an `HttpRequestMessage` with the `X-Name: alice` header. Framework logging is silenced via `Logging.ClearProviders()`, so the printed body is exactly the header value returned from the real HTTP response.

## Run

    dotnet run

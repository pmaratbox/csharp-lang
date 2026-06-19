# 0621 — Read a response header

This lesson uses the .NET `HttpClient` (from `System.Net.Http`) to call an in-process server. The server is a custom `HttpMessageHandler` subclass (`Stub`) wired into the client via `new HttpClient(new Stub())` — no socket, no port. The handler's `/info` route attaches a custom `X-Count: 7` response header, and the client reads it back with `response.Headers.GetValues("X-Count").First()`.

## Run

    dotnet run

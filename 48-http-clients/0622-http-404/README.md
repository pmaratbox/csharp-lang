# 0622 — Handle 404

Uses `System.Net.Http.HttpClient` (the .NET HTTP client library) against an in-process server implemented as a custom `HttpMessageHandler` subclass — so there is no socket, port, or external network. The stub server defines no routes, so the request to `GET /missing` returns `HttpStatusCode.NotFound`. The client reads the response and prints the integer status code `404`.

## Run

    dotnet run

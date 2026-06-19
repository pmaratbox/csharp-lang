# 0615 — GET request

Uses the .NET `System.Net.Http.HttpClient` library to make a GET request and read the response body. The in-process server is a custom `HttpMessageHandler` subclass (`Stub`) that the `HttpClient` is constructed with, so requests are served directly in memory with no socket, no port, and no external network. The handler answers `GET /hello` with the fixed text body `hello world`, and the client retrieves it via `GetStringAsync("/hello")`, printing `hello world`.

## Run

    dotnet run

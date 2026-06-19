# 0624 — PUT request

This lesson uses .NET's real `HttpClient` from `System.Net.Http` to make a `PUT` request. The server is in-process: a custom `HttpMessageHandler` subclass (`Stub`) intercepts requests and returns a fixed `HttpResponseMessage` with no socket or port involved. The client sends `PUT /item` and prints the response body, which the server returns as `updated`.

## Run

    dotnet run

# 0617 — Parse JSON response

Uses the .NET `System.Net.Http.HttpClient` library to call an in-process server with no socket or port: a custom `HttpMessageHandler` subclass (`Stub`) returns a fixed `HttpResponseMessage` directly, and the client is built with `new HttpClient(new Stub())`. The client issues `GET /user`, which yields the JSON body `{"name":"Alice","age":30}`; the response is parsed with `System.Text.Json` (`JsonDocument.Parse`) and the `name` field is printed, giving `Alice`.

## Run

    dotnet run

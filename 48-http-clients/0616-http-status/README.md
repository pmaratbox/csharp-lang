# 0616 — Response status code

Uses the built-in `System.Net.Http.HttpClient` to call an in-process server with no socket or port: a custom `HttpMessageHandler` subclass (`Stub`) intercepts requests and returns fixed `HttpResponseMessage` objects. The handler maps `GET /hello` to a `200 OK` response. The client issues `GetAsync("/hello")` and prints the integer status code via `(int)resp.StatusCode`, giving `200`.

## Run

    dotnet run

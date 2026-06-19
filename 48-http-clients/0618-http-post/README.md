# 0618 — POST a body

Uses the built-in `System.Net.Http.HttpClient` to make a request to an in-process server. The server is a custom `HttpMessageHandler` subclass (`Stub`) wired into the client — no socket, port, or external network is involved. The `POST /echo` route reads the request body and returns it verbatim, so posting the text `ping` via `client.PostAsync` and reading the response body prints `ping`.

## Run

    dotnet run

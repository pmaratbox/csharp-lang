# 0623 — POST JSON, parse JSON

Uses the built-in `System.Net.Http.HttpClient` to make a request to an in-process server. The server is a custom `HttpMessageHandler` subclass (`Stub`) wired into the client — no socket, port, or external network is involved. The `POST /double` route reads JSON `{"x":N}` and returns `{"doubled":2N}`, so posting `{"x":5}` via `client.PostAsync`, parsing the reply with `System.Text.Json`, and reading the `doubled` field prints `10`.

## Run

    dotnet run

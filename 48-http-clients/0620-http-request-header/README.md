# 0620 — Send a request header

Uses the built-in `System.Net.Http.HttpClient` to make a real client request to an in-process server. The server is a custom `HttpMessageHandler` subclass (`Stub`) wired into the client via `new HttpClient(new Stub())` — no sockets and no port are involved. The `GET /token` route reads the request's `X-Token` header and echoes it back in the body. The client sends `X-Token: secret` on the request, and the body it reads back is `secret`.

## Run

    dotnet run

# 0619 — Query parameters

Uses the built-in `System.Net.Http.HttpClient` to call an in-process server with no socket or port: a custom `HttpMessageHandler` subclass (`Stub`) intercepts requests and returns fixed `HttpResponseMessage` objects. The handler maps `GET /greet`, reads the `name` query parameter from the request URI (parsed manually as `q.TrimStart('?').Split('=')[1]`), and returns `hi <name>`. The client issues `GetStringAsync("/greet?name=Bob")`, so the printed body is `hi Bob`.

## Run

    dotnet run

# 0501 — Middleware

Uses ASP.NET Core's middleware pipeline (`app.Use(...)`) to transform an HTTP response. The middleware swaps `Response.Body` for an in-memory buffer, runs the downstream handler (`GET /` returns `hello`), reads the buffered body, and rewrites it to the real stream prefixed with `[mw] `. The prefix is added entirely by the middleware, not the handler. The route is exercised in-process with `Microsoft.AspNetCore.TestHost` via `UseTestServer()` and `GetTestClient()`, and logging is cleared so only the response body prints.

## Run

    dotnet run

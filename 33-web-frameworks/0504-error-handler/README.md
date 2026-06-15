# 0504 — Error handler

Uses ASP.NET Core's minimal API (`WebApplication`) with a `GET /boom` route whose handler throws an `InvalidOperationException`. The `UseExceptionHandler` middleware catches the unhandled exception and turns it into a `500 Internal Server Error` — the status is produced by the framework's error handling, not hardcoded. The app runs in-process on `Microsoft.AspNetCore.TestHost`'s `TestServer` (configured with `builder.WebHost.UseTestServer()`), so no fixed TCP port is bound; `app.GetTestClient()` issues the request directly through the in-memory server. The printed value is the real HTTP status code from the response (`(int)resp.StatusCode`). `builder.Logging.ClearProviders()` silences framework startup/request logging so only the status code prints.

## Run

    dotnet run

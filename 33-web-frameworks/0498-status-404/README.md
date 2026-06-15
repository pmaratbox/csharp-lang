# 0498 — 404 status

Uses ASP.NET Core's minimal API (`WebApplication`) with a single `GET /` route, then requests an undefined route (`GET /missing`). Because no handler matches, the framework's routing returns a `404 Not Found`. The app runs in-process on `Microsoft.AspNetCore.TestHost`'s `TestServer` (configured with `builder.WebHost.UseTestServer()`), so no fixed TCP port is bound; `app.GetTestClient()` issues the request directly through the in-memory server. The printed value is the real HTTP status code from the response (`(int)resp.StatusCode`). `builder.Logging.ClearProviders()` silences framework startup/request logging so only the status code prints.

## Run

    dotnet run

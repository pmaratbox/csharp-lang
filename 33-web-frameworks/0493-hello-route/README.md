# 0493 — Hello route

Uses ASP.NET Core's minimal API (`WebApplication`) to define a single `GET /` route returning the text `hello`. The app runs in-process on `Microsoft.AspNetCore.TestHost`'s `TestServer` (configured with `builder.WebHost.UseTestServer()`), so no fixed TCP port is bound. `app.GetTestClient()` issues the request directly through the in-memory server and the printed value is the actual HTTP response body. `builder.Logging.ClearProviders()` silences framework startup/request logging so only the body prints.

## Run

    dotnet run

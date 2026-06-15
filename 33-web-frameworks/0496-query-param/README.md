# 0496 — Query parameter

Uses ASP.NET Core's minimal API (`WebApplication`) to define `GET /greet`, where the `name` handler argument is bound from the query string and the handler returns `hello ` + the name. The app runs in-process on `Microsoft.AspNetCore.TestHost`'s `TestServer` (configured with `builder.WebHost.UseTestServer()`), so no fixed TCP port is bound. `app.GetTestClient()` issues `GET /greet?name=alice` directly through the in-memory server and the printed value is the actual HTTP response body. `builder.Logging.ClearProviders()` silences framework startup/request logging so only the body prints.

## Run

    dotnet run

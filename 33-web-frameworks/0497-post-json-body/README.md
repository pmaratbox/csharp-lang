# 0497 — POST JSON body

Uses ASP.NET Core's minimal API (`WebApplication`) to define a `POST /sum` route whose handler binds the JSON request body to a `Nums` record (`{a, b}`) and returns their sum. The app runs in-process on `Microsoft.AspNetCore.TestHost`'s `TestServer` (`builder.WebHost.UseTestServer()`), so no fixed TCP port is bound. `app.GetTestClient().PostAsJsonAsync(...)` sends the JSON body through the in-memory server, and the printed value is the actual HTTP response body. `builder.Logging.ClearProviders()` silences framework startup/request logging so only the sum prints.

## Run

    dotnet run

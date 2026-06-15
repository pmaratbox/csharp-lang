# 0499 — Custom status

Uses ASP.NET Core minimal APIs to map `POST /create`, whose handler returns `Results.StatusCode(201)` so the framework responds with the custom `201 Created` status. The route is exercised in-process via `Microsoft.AspNetCore.TestHost` (`UseTestServer()` + `app.GetTestClient()`), so no fixed port is bound. The actual HTTP response status code (`201`) read from the framework's response is printed. Logging providers are cleared so only the status prints.

## Run

    dotnet run

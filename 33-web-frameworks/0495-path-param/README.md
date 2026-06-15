# 0495 — Path parameter

Uses ASP.NET Core minimal APIs to map `GET /users/{id}`, where `{id}` is a route (path) parameter bound to the handler argument. The route is exercised in-process via `Microsoft.AspNetCore.TestHost` (`UseTestServer()` + `app.GetTestClient()`), so no fixed port is bound. Requesting `/users/42` makes the handler echo the captured `id`, and the actual HTTP response body (`42`) is printed. Logging providers are cleared so only the response prints.

## Run

    dotnet run

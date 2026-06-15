# 0494 — JSON response

Uses ASP.NET Core minimal APIs to map `GET /user` to a handler that returns `Results.Json(new { name = "alice" })`, serializing an object to a compact JSON body. The route is exercised in-process with `Microsoft.AspNetCore.TestHost` (`UseTestServer` + `app.GetTestClient()`), so no fixed port is bound; the printed value is the actual HTTP response body. Logging providers are cleared so only the body prints.

## Run

    dotnet run

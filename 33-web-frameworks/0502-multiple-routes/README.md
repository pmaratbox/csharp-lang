# 0502 — Multiple routes

Uses ASP.NET Core Minimal APIs to register two routes, `GET /` returning `home` and `GET /about` returning `about`, then exercises them in-process via the `Microsoft.AspNetCore.TestHost` test server (`UseTestServer` + `GetTestClient`) so no fixed port is bound. Each route's actual HTTP response body is fetched in order and printed on its own line. Logging providers are cleared so framework startup/request logs do not pollute stdout.

## Run

    dotnet run

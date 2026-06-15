# 0503 — Method routing

Uses ASP.NET Core Minimal APIs to register two handlers on the same path `/item` — `GET /item` returning `get` and `POST /item` returning `post` — then exercises them in-process via the `Microsoft.AspNetCore.TestHost` test server (`UseTestServer` + `GetTestClient`) so no fixed port is bound. A `POST /item` request is sent through the test client and the framework dispatches it to the POST handler; its actual HTTP response body is read and printed. Logging providers are cleared so framework startup/request logs do not pollute stdout.

## Run

    dotnet run

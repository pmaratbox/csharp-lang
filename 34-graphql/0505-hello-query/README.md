# 0505 — Hello query

Uses HotChocolate's `HotChocolate.Execution` to build a GraphQL schema in-process (`type Query { hello: String }`, where the `Hello()` method on the `Query` class resolves to `"world"`) and execute the query `{ hello }` directly against the request executor — no HTTP server. The result's `op.Data!["hello"]` is the value actually resolved by the schema, which is printed.

## Run

    dotnet run

# 0509 — Nested object

Uses HotChocolate (the `HotChocolate.Execution` GraphQL library) to build a schema in-process where `Query.user` returns a `User` object type that itself exposes an `Address` object type. The query `{ user { address { city } } }` is executed directly against the request executor (no HTTP server); HotChocolate resolves each level of the nested object selection. The printed value is extracted from the execution result by walking `data.user.address.city`.

## Run

    dotnet run

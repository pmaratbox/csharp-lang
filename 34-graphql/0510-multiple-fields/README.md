# 0510 — Multiple fields

Uses the HotChocolate GraphQL library to build a schema with a `User` object type (`name`, `age`) exposed through `Query.user`. A single GraphQL selection set can request several fields of one object at once, so executing `{ user { name age } }` in-process (no HTTP server) resolves both fields. The values are extracted from the execution result's `data.user` map and printed (`name` then `age`, each on its own line).

## Run

    dotnet run

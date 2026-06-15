# 0508 — List field

Uses the HotChocolate GraphQL library to build a schema whose `Query.numbers: [Int]` resolver returns a list of scalars. Executing `{ numbers }` in-process (no HTTP server) resolves the field, and each element extracted from the execution result's `data.numbers` list is printed on its own line.

## Run

    dotnet run

# 0506 — Field argument

Uses the HotChocolate GraphQL library to build a schema where `Query.greet(name: String!)` takes a field argument. HotChocolate maps the resolver method's `name` parameter to the GraphQL field argument, so executing `{ greet(name: "alice") }` in-process (no HTTP server) resolves the field and the value extracted from the execution result's `data.greet` (`hello alice`) is printed.

## Run

    dotnet run

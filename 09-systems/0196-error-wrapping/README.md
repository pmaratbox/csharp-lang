# 0196 — Error Wrapping

Wrap an inner error "inner" inside an outer context and print the combined message `outer: inner`. C# wraps a cause by passing it as the `innerException` argument and reading it back via `InnerException`.

## Run

    dotnet run

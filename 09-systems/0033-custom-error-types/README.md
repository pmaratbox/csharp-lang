# 0033 — Custom Error Types

Define a custom error, raise it from a `check` that rejects values over `100`, catch it for the input `200`, and print `error: value too large`. A custom exception derives from `Exception` and passes its message to `base(...)` (read back via `.Message`); `throw` raises it and a typed `catch (TooLargeException e)` handles it. C# exceptions are all unchecked.

## Run

    dotnet run

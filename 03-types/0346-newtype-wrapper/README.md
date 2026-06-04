# 0346 — Newtype Wrapper

Wrap raw integers in distinct UserId and ProductId types so they cannot be confused, printing `user-1 prod-2`. C# uses single-field `readonly record struct` wrappers with a custom `ToString` for each newtype.

## Run

    dotnet run

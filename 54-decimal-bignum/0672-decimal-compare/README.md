# 0672 — Exact decimal comparison

This lesson checks whether `0.1 + 0.2` equals `0.3` using C#'s built-in `decimal` type, a 128-bit base-10 exact-decimal type. Because `decimal` stores values in base 10 rather than binary floating point, the sum is exactly `0.3` and the `==` comparison returns `true` (unlike `double`, where `0.1 + 0.2` differs from `0.3`). The boolean is printed in lowercase.

## Run

    dotnet run

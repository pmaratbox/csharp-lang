# 0391 — URL Percent-Encode

Percent-encode the string "a b&c" to `a%20b%26c`. C# keeps unreserved characters and emits `%` plus uppercase hex via the `X2` format specifier.

## Run

    dotnet run

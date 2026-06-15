# 0560 — SHA-512

Uses the .NET standard library's [`System.Security.Cryptography`](https://learn.microsoft.com/dotnet/api/system.security.cryptography) namespace. The string `"hello"` is UTF-8 encoded and passed to `SHA512.HashData`, which returns the 64-byte SHA-512 digest. `Convert.ToHexString(...).ToLower()` renders it as a lowercase hex string with no separators.

## Run

    dotnet run

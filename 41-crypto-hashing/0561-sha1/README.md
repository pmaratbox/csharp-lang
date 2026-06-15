# 0561 — SHA-1

Uses the .NET `System.Security.Cryptography` library to compute the SHA-1 digest of the UTF-8 bytes of `"hello"`. `SHA1.HashData` returns the 20-byte hash, and `Convert.ToHexString(...).ToLower()` renders it as a lowercase hex string with no separators. SHA-1 is legacy and cryptographically broken, but remains useful for learning; the result is the deterministic 40-character digest `aaf4c61ddcc5e8a2dabede0f3b482cd9aea9434d`.

## Run

    dotnet run

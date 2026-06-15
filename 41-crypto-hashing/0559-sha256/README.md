# 0559 — SHA-256

Uses the .NET `System.Security.Cryptography` library to compute the SHA-256 digest of the UTF-8 bytes of `"hello"`. `SHA256.HashData` returns the 32-byte hash, and `Convert.ToHexString(...).ToLower()` renders it as a lowercase hex string with no separators. The result is the deterministic 64-character digest `2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824`.

## Run

    dotnet run

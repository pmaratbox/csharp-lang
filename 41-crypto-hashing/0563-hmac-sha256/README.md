# 0563 — HMAC-SHA256

Uses the .NET `System.Security.Cryptography` library to compute an HMAC-SHA256 message authentication code. We construct `new HMACSHA256(key)` with the UTF-8 bytes of the key `"key"`, call `ComputeHash` over the UTF-8 bytes of the message `"hello"`, and render the resulting 32-byte tag as a lowercase hex string with no separators via `Convert.ToHexString(...).ToLower()`.

## Run

    dotnet run

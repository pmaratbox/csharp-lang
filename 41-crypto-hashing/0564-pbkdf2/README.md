# 0564 — PBKDF2

Uses the .NET `System.Security.Cryptography` library to derive a key with PBKDF2-HMAC-SHA256. `Rfc2898DeriveBytes.Pbkdf2` stretches the password `"password"` with the salt `"salt"` over 1000 iterations, producing a 32-byte derived key. The bytes are formatted as lowercase hex with `Convert.ToHexString(...).ToLower()`.

## Run

    dotnet run

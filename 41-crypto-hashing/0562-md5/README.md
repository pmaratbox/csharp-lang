# 0562 — MD5

Uses the .NET standard library's [`System.Security.Cryptography`](https://learn.microsoft.com/dotnet/api/system.security.cryptography) namespace. The `MD5.HashData` method computes the 128-bit MD5 digest of the UTF-8 bytes of `"hello"`, and `Convert.ToHexString(...).ToLower()` formats the 16-byte result as a lowercase hex string (no colons or spaces), giving `5d41402abc4b2a76b9719d911017c592`. MD5 is cryptographically broken and shown here only for legacy/checksum purposes.

## Run

    dotnet run

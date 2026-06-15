# 0566 — Incremental hashing

Uses the .NET `System.Security.Cryptography` library to compute a SHA-256 digest incrementally. `IncrementalHash.CreateHash(HashAlgorithmName.SHA256)` builds a streaming hasher that is fed the UTF-8 bytes of `"foo"` and then `"bar"` in two separate `AppendData` update calls, and `GetHashAndReset` finalizes the 32-byte hash. `Convert.ToHexString(...).ToLower()` renders it as a lowercase hex string with no separators. The result equals the SHA-256 of `"foobar"`: the deterministic 64-character digest `c3ab8ff13720e8ad9047dd39466b3c8974e592c2fa383d4a3960714caef0c4f2`.

## Run

    dotnet run

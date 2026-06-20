# 0707 — UUIDv5 (name-based)

This lesson uses the **UUIDNext** library to generate a UUIDv5. A v5 UUID is
*name-based*: it is the SHA-1 hash of a namespace plus a name, so the same
`(namespace, name)` pair always yields the same UUID — fully deterministic, with
no randomness. Here we use the standard DNS namespace
(`6ba7b810-9dad-11d1-80b4-00c04fd430c8`) and the name `example.com`.

## Run

    dotnet run

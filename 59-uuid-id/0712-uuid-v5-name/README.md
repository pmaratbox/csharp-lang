# 0712 — UUIDv5 of another name

This lesson uses the **UUIDNext** library to generate a UUIDv5. A v5 UUID is the
SHA-1 hash of a namespace plus a name, so it is fully deterministic and
*name-dependent*: a different name yields a different UUID. Using the standard
DNS namespace (`6ba7b810-9dad-11d1-80b4-00c04fd430c8`) with the name `test.com`
produces a value distinct from the one for `example.com`, while still being the
same every time for `test.com`.

## Run

    dotnet run

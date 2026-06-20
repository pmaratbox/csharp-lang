# 0708 — UUIDv5 is stable

Uses the UUIDNext library (`Uuid.NewNameBased`) to generate a UUIDv5 in the DNS namespace (`6ba7b810-9dad-11d1-80b4-00c04fd430c8`) for the name `example.com` TWICE. Because UUIDv5 is name-based (SHA-1 of namespace + name), it is fully deterministic: the two results are identical, so comparing them with `==` prints `true`.

## Run

    dotnet run

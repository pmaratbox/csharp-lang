# 0614 — Decode bytes

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to decode MessagePack binary back into a value. The hex string `a568656c6c6f` is converted to bytes with `Convert.FromHexString(...)`, then decoded via `MessagePackSerializer.Deserialize<string>(...)`. The leading `a5` is the fixstr header for a 5-byte string, so the bytes decode to `hello`.

## Run

    dotnet run

# 0613 — Encode null

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to encode `null` into MessagePack binary via `MessagePackSerializer.Serialize<object?>(null)`, then prints the lowercase hex of the bytes with `Convert.ToHexString(...).ToLower()`. MessagePack has a dedicated nil format, so `null` serializes to the single byte `c0`.

## Run

    dotnet run

# 0609 — Encode a boolean

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to encode the boolean `true` into MessagePack binary via `MessagePackSerializer.Serialize`, then prints the lowercase hex of the bytes with `Convert.ToHexString(...).ToLower()`. MessagePack has dedicated single-byte tokens for booleans, so `true` becomes `c3` (and `false` would be `c2`).

## Run

    dotnet run

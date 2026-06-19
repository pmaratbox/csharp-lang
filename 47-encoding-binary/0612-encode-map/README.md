# 0612 — Encode a map

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to encode the single-key map `{"a": 1}` into MessagePack binary via `MessagePackSerializer.Serialize`, then prints the lowercase hex of the bytes with `Convert.ToHexString(...).ToLower()`. A one-entry map serializes to a fixmap header `81`, the fixstr key `a161` (`"a"`), and the positive-fixint value `01`, giving `81a16101`.

## Run

    dotnet run

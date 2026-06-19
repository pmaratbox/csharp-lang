# 0607 — Encode an integer

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to encode the integer `42` into MessagePack binary via `MessagePackSerializer.Serialize`, then prints the lowercase hex of the bytes with `Convert.ToHexString(...).ToLower()`. Small positive integers serialize to a single positive-fixint byte, so `42` becomes `2a`.

## Run

    dotnet run

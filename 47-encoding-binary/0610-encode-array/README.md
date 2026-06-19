# 0610 — Encode an array

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to encode the integer array `[1, 2, 3]` into MessagePack binary via `MessagePackSerializer.Serialize`, then prints the lowercase hex of the bytes with `Convert.ToHexString(...).ToLower()`. A short array serializes to a single fixarray header byte (`93` for length 3) followed by each element as a positive fixint, so it becomes `93010203`.

## Run

    dotnet run

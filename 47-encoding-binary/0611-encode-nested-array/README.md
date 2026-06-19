# 0611 — Encode a nested array

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to encode the nested array `[[1, 2], [3, 4]]` into MessagePack binary via `MessagePackSerializer.Serialize`, then prints the lowercase hex of the bytes with `Convert.ToHexString(...).ToLower()`. The outer two-element array becomes `92`, and each inner two-element array is `92` followed by its positive fixints, giving `92920102920304`.

## Run

    dotnet run

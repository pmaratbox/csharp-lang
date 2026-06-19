# 0608 — Encode a string

Uses the [MessagePack](https://github.com/MessagePack-CSharp/MessagePack-CSharp) library to MessagePack-encode the string `"hello"`. The bytes come back as a fixstr header (`a5`) followed by the UTF-8 bytes of `hello`, which we print as lowercase hex via `Convert.ToHexString(...).ToLower()`.

## Run

    dotnet run

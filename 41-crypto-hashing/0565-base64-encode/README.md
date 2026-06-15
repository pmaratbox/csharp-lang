# 0565 — Base64 encode

Uses the .NET base-class library `System.Convert` to Base64-encode bytes. We take the UTF-8 bytes of the fixed string `"hello"` via `Encoding.UTF8.GetBytes` and run them through `Convert.ToBase64String`, which applies the standard Base64 alphabet (RFC 4648) and prints the encoded string.

## Run

    dotnet run

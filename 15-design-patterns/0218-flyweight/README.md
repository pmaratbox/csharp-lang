# 0218 — Flyweight

Share flyweight instances for repeated characters a, b, a and print the number of distinct objects created `2`. A factory caches one `Glyph` per character in a `Dictionary`, so repeats reuse the instance.

## Run

    dotnet run

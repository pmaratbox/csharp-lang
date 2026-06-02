# 0074 — Run-Length Encoding

Run-length encode the string `aaabbc` (each run of a repeated character becomes the character followed by its count), printing `a3b2c1`. A `StringBuilder` accumulates each run's character and count; the inner loop measures the run length.

## Run

    dotnet run

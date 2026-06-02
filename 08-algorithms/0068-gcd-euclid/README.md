# 0068 — GCD (Euclid)

Compute the greatest common divisor of `48` and `36` with Euclid's algorithm (repeatedly replace the pair with `(b, a % b)` until the remainder is zero) and print it: `12`. Tuple deconstruction `(a, b) = (b, a % b)` advances both values each step until `b` is zero.

## Run

    dotnet run

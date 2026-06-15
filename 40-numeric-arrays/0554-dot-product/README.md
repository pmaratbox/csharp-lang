# 0554 — Dot product

This lesson uses the **MathNet.Numerics** linear-algebra library to compute the
**dot product** of two vectors. We build dense `Vector<double>` instances from
`[1, 2, 3]` and `[4, 5, 6]`, then call `DotProduct`, which sums the pairwise
products (`1*4 + 2*5 + 3*6`). The result is integer-valued, so we round and cast
to `int` before printing — no decimal point.

## Run

    dotnet run

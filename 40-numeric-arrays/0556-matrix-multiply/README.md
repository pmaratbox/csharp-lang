# 0556 — Matrix multiply

This lesson uses the **MathNet.Numerics** linear-algebra library to perform
**matrix multiplication**. We build two dense `Matrix<double>` instances from
`[[1, 2], [3, 4]]` and `[[5, 6], [7, 8]]`, then multiply them with the `*`
operator, which computes the standard matrix product. Each result entry is
integer-valued, so we round and cast to `int` and print one row per line with
space-joined elements — no decimal points.

## Run

    dotnet run

# 0557 — Transpose

Uses the [Math.NET Numerics](https://numerics.mathdotnet.com/) linear algebra library. A 2x3 matrix `[[1,2,3],[4,5,6]]` is built with `Matrix<double>.Build.DenseOfArray`, then `.Transpose()` swaps its rows and columns to produce the 3x2 result. Each transposed row is printed as space-joined integers via `(int)Math.Round`.

## Run

    dotnet run

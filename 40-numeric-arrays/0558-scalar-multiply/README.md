# 0558 — Scalar multiply

Uses the [MathNet.Numerics](https://numerics.mathdotnet.com/) linear-algebra library. We build the dense matrix `[[1,2],[3,4]]` with `Matrix<double>.Build.DenseOfArray` and apply the scalar-multiplication operator `a * 3.0`, which scales every element by 3. Each resulting row is rounded to an integer and printed space-joined, one row per line.

## Run

    dotnet run

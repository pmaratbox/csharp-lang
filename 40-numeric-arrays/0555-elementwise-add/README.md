# 0555 — Element-wise add

Uses the [MathNet.Numerics](https://numerics.mathdotnet.com/) linear-algebra library. Two dense vectors `[1,2,3]` and `[10,20,30]` are built with `Vector<double>.Build.DenseOfArray`, then combined with the `+` operator, which performs an *element-wise add* (each pair of components is summed). The result is rounded to integers and printed space-joined.

## Run

    dotnet run

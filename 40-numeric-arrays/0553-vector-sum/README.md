# 0553 — Vector sum

Uses the [MathNet.Numerics](https://numerics.mathdotnet.com/) linear-algebra library. A dense `Vector<double>` is built from `[1, 2, 3, 4]` with `Vector<double>.Build.DenseOfArray`, and its elements are added together by the library's `.Sum()` operation. The total is rounded and cast to an integer before printing, giving `10`.

## Run

    dotnet run

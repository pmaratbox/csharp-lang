# 0114 — Zip With

Combine [1,2,3] and [4,5,6] element-wise with addition, printing `5 7 9`. LINQ's `Zip` takes a result selector, so `a.Zip(b, (x, y) => x + y)` is the idiomatic `zipWith(+)`.

## Run

    dotnet run

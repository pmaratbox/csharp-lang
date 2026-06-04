# 0324 — Either Monad

Chain Either computations: a successful divide chain yields 2, and a divide-by-zero yields an error, printing `2 err`. A generic `Either<L,R>` with `Bind` short-circuits to `Left`.

## Run

    dotnet run

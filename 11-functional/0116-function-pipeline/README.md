# 0116 — Function Pipeline

Compose inc, double, and negate into a left-to-right pipeline and apply it to 3: ((3+1)*2) negated = `-8`. `Pipe` folds the input through each delegate with LINQ's `Aggregate`, threading the result left to right.

## Run

    dotnet run

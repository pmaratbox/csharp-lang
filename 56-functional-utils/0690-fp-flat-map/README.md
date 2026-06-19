# 0690 — Flat map

This lesson uses LINQ (the C# standard query library) and its `SelectMany` operator
to flat-map `[1, 2, 3]`: each element `x` is mapped to the sequence `[x, x*10]`, and
`SelectMany` flattens those sequences into one, comma-joined to `1,10,2,20,3,30`.

## Run

    dotnet run

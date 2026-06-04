# 0199 — Struct Field Names

List the field names of a Point{x,y} struct/record and print `x y`. C# uses reflection (`typeof(T).GetProperties()`) to read a positional record struct's member names in declaration order.

## Run

    dotnet run

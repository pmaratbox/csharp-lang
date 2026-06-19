# 0684 — Chunk

Uses LINQ (the .NET standard query library) and its `Chunk` operator to split `[1,2,3,4,5,6]` into fixed-size pieces of 2. Each chunk is comma-joined and the chunks are joined with `|`, yielding `1,2|3,4|5,6`.

## Run

    dotnet run

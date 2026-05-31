# 0001 — Hello, world!

The minimal C# program: a single call to `Console.WriteLine`. Modern C# uses
top-level statements, so no explicit `class` or `Main` method is needed — the
compiler synthesizes the entry point. The `.csproj` sets `OutputType` to `Exe`
and enables implicit usings, which brings `System` into scope automatically.

## Run

    dotnet run

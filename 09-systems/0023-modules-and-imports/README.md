# 0023 — Modules & Imports

Define `square(n)` in a separate `mathutil` module and import it from the main program, printing `square(8) = 64` across the module boundary. `Mathutil.cs` puts a static class in `namespace MathUtil`, and `Program.cs` brings it into scope with `using MathUtil`. `dotnet run` compiles every `.cs` file in the project together, so the two files link without any explicit reference.

## Run

    dotnet run

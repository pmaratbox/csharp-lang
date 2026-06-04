# 0214 — Visitor

Use a visitor to sum the values of a small node tree with leaves 1, 2, 3, printing `6`. Each `Leaf.Accept` double-dispatches to `IVisitor.Visit`, accumulating the total.

## Run

    dotnet run

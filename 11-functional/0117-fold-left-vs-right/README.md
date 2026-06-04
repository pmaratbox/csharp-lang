# 0117 — Fold Left vs Right

Fold subtraction over [1,2,3] from 0 both ways: left ((((0-1)-2)-3)) = -6 and right (1-(2-(3-0))) = 2, printing `-6 2`. LINQ's `Aggregate` is a left fold, so the right fold is expressed by reversing the sequence and flipping the accumulator argument.

## Run

    dotnet run

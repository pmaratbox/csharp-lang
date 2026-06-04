# 0211 — Command (Undo)

Execute an AddCommand that takes a counter from 0 to 5, then undo it back to 0, printing `5 0`. The command captures the receiver and amount, so `Undo()` simply reverses the effect.

## Run

    dotnet run

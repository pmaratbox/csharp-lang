# 0195 — Defer LIFO Order

Register three deferred actions printing 1, 2, 3 and show they run in last-in-first-out order `3 2 1`. C# has no `defer`, so `using` declarations of a disposable wrapper dispose in reverse order to emulate LIFO.

## Run

    dotnet run

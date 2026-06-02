# 0027 — File I/O

Write `hello, file` to a file, read it back, delete the file, and print `read: hello, file`. `System.IO.File` exposes one-call static helpers — `WriteAllText`, `ReadAllText` (UTF-8 by default), and `Delete` — that open and close the file internally. Streaming APIs (`StreamReader`/`StreamWriter`) handle files too large to hold in memory.

## Run

    dotnet run

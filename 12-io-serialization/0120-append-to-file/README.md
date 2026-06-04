# 0120 — Append to a File

Write "a" to a file, append "b", then read both lines back and print `a b`. C# uses `File.WriteAllText` then `File.AppendAllText` for write-then-append semantics.

## Run

    dotnet run

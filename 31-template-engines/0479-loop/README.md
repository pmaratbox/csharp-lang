# 0479 — Loop

Render a fixed template with the Scriban engine that iterates the fixed list `nums = [1, 2, 3]` using a `{{ for n in nums }}` loop, printing each element on its own line. The loop's built-in `for.last` flag suppresses the newline after the final item so the output is `1\n2\n3` with no trailing separator.

## Run

    dotnet run

# 0022 — Concurrency

Start two tasks that produce `1` and `2`, let them run concurrently, then join their results and print `sum: 3`. `Task.Run` queues each task on the thread pool and returns a `Task<int>`; `await Task.WhenAll` asynchronously waits for both. Top-level `await` is allowed in the program's top-level statements. Tasks underpin C#'s `async`/`await` model.

## Run

    dotnet run

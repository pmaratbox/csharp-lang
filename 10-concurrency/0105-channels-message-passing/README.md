# 0105 — Channels / Message Passing

Send the values 1, 2, 3 through a channel (or queue) from one thread and receive them in order, printing `1 2 3`. `System.Threading.Channels` provides an async producer/consumer queue read with `await foreach`.

## Run

    dotnet run

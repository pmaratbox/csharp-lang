# 0410 — Merge Streams

Implement merge of two timed streams using a virtual-time scheduler, interleaving them by emission time. Uses a from-scratch push Observable plus a PriorityQueue keyed on (time, insertion-seq) so equal-time ties break by enqueue order.

## Run

    dotnet run

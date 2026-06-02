# 0026 — Sets

Build a set from `1, 2, 2, 3` so the duplicate collapses, then print its `size: 3` and whether it contains `2` (`has 2: yes`) and `5` (`has 5: no`). `HashSet<int>` stores unique values with O(1) average `Add`/`Contains`; the collection initializer drops the duplicate `2`. `.Count` reports the size. `SortedSet<int>` is the ordered, tree-based counterpart.

## Run

    dotnet run

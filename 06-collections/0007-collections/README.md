# 0007 — Collections

Build a list of the integers `1, 2, 3, 4, 5`, then print its count and its
first and last elements. `List<int>` is the growable, generic workhorse, built
here with a collection expression (`[...]`); its size is the `Count` property
(arrays use `Length` instead). There is no negative indexing, but the `^`
index-from-end operator makes `nums[^1]` the idiomatic "last element".

## Run

    dotnet run

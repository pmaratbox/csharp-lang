# 0009 — Maps

Build a `Dictionary<string, int>` `{"one": 1, "two": 2, "three": 3}`, look up
`"two"`, and print its value and the dictionary's count. `Dictionary<TKey,
TValue>` is the BCL's hash map; the collection initializer `["key"] = value`
seeds entries, `dict[key]` returns the value (throwing `KeyNotFoundException`
if absent — use `TryGetValue` for a safe lookup), and `.Count` counts entries.

## Run

    dotnet run

# 0173 — Trie

Insert "cat" and "car" into a trie, then search "car" (yes) and "can" (no), printing `yes no`. Each node holds a `Dictionary<char, TrieNode>` of children plus an `IsWord` flag, so insert and search both walk character by character.

## Run

    dotnet run

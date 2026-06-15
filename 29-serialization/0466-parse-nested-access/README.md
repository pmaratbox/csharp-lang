# 0466 — Parse & access nested

Parse JSON and read a deeply nested value. This lesson uses the built-in `System.Text.Json` library's mutable DOM API (`JsonNode.Parse`) to parse a JSON string into a tree, then navigates with indexers to read `user.name` and the first element of `user.roles`, printing both values.

## Run

    dotnet run

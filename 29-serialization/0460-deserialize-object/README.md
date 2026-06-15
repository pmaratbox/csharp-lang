# 0460 — Deserialize object

Parse a JSON string into a typed object using the built-in System.Text.Json library. This lesson calls `JsonSerializer.Deserialize<Person>` with a `JsonSerializerOptions` configured for `JsonNamingPolicy.CamelCase`, mapping the JSON keys `age` and `name` onto the `Person(Age, Name)` record, then prints the parsed values.

## Run

    dotnet run

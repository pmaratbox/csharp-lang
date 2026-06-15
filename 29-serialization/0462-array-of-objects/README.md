# 0462 — Array of objects

Serialize a list of objects to a JSON array. This lesson uses the built-in `System.Text.Json` library: `JsonSerializer.Serialize` turns a `List<Person>` into a compact JSON array, with `JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase` mapping the alphabetically-declared `Age`/`Name` record properties to lowercase `age`/`name` keys.

## Run

    dotnet run

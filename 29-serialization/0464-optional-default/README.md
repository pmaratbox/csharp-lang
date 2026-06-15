# 0464 — Optional field with default

Uses the built-in `System.Text.Json` library to deserialize JSON where an optional field is missing. The `age` key is absent from `{"name":"alice"}`, so `JsonSerializer.Deserialize<Person>` leaves it at the record parameter's default value (`0`). Record parameters are declared in alphabetical order (`Age`, `Name`) and mapped to camelCase keys via `JsonNamingPolicy.CamelCase`.

## Run

    dotnet run

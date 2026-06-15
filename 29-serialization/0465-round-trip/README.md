# 0465 — Round trip

Serialize an object to JSON and then deserialize it back, both directions through the same library. This lesson uses the built-in `System.Text.Json` library: `JsonSerializer.Serialize` turns a `Person` record into a compact JSON string, and `JsonSerializer.Deserialize<Person>` reconstructs the record from that string. The recovered name is printed.

## Run

    dotnet run

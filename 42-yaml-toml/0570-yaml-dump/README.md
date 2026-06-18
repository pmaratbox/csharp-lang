# 0570 — Dump YAML

This lesson uses the **YamlDotNet** library to serialize a map to sorted block-style YAML. A `SortedDictionary<string, object>` holding `name=Alice`, `age=30`, and `city=Paris` is passed to `new SerializerBuilder().Build().Serialize(...)`, which emits the keys in sorted order as plain block-style scalars (no flow braces, no quotes).

## Run

    dotnet run

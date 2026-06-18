# 0569 — YAML sequence

Uses the `YamlDotNet` library to parse a YAML document containing a sequence (list) under the `fruits` key. The deserializer returns a `Dictionary<string, object>` whose `fruits` value is a `List<object>`; joining its elements with commas yields `apple,banana,cherry`.

## Run

    dotnet run

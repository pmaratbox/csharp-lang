# 0567 — YAML scalars

Uses the YamlDotNet library to parse the YAML mapping `name: Alice\nrole: admin\nage: 30\n` into a `Dictionary<string, object>`. The deserializer reads each scalar field, recognizing `age` as the integer `30`. The three values are then printed space-joined as `Alice admin 30`.

## Run

    dotnet run

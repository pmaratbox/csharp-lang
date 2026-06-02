# 0031 — Type Conversion & Parsing

Parse the string `"42"` into an integer and `"3.5"` into a float, then convert the integer back to a string, printing `int: 42`, `float: 3.5`, and `str: 42`. `int.Parse`/`double.Parse` throw on bad input (with `TryParse` as the non-throwing form), and `ToString` converts back. `double.Parse` is given `CultureInfo.InvariantCulture` so `"3.5"` is read with a dot regardless of the machine's locale.

## Run

    dotnet run

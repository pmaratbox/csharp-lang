# 0028 — String Formatting

Format the float `3.14159` to two decimals and zero-pad the integer `42` to width five, printing `pi: 3.14` and `id: 00042`. Composite/interpolated formatting uses `{value:format}`: `F2` fixes two decimals and `D5` zero-pads an integer to width 5. The float is formatted with `CultureInfo.InvariantCulture` so the decimal mark is a dot.

## Run

    dotnet run

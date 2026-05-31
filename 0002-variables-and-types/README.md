# 0002 — Variables & basic types

Declare locals of C#'s four basic types (`int`, `double`, `string`, `bool`)
and print each via an interpolated `$"..."` string. These keywords are
aliases for `System.Int32`, `System.Double`, `System.String`, and
`System.Boolean`; `var` would infer the same types from the literals. The
`double` is formatted with `CultureInfo.InvariantCulture` so it always uses
a `.` decimal point, and C# renders `bool` with a capital `True`/`False`,
which is the language convention.

## Run

    dotnet run

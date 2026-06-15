# 0487 — Minimum length

Validate a model with the FluentValidation library. The rule `RuleFor(x => x.Name).MinimumLength(3)` requires `Name` to be at least 3 characters; validating `{name:'al', age:30}` fails because `"al"` is only 2 characters. The program prints the sorted, lowercased failing field name(s) pulled from `result.Errors` (via each error's `PropertyName`), or `ok` when validation passes — never the library's message text.

## Run

    dotnet run

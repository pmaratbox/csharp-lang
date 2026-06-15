# 0486 — Required field

FluentValidation marks both `name` and `age` as required via `RuleFor(...).NotNull()`. The input has `name` present but `age` missing (null), so the `age` rule fails. The output is the failing field name(s) — lowercased, deduped, and sorted — extracted from `result.Errors[].PropertyName`, or `ok` when validation passes.

## Run

    dotnet run

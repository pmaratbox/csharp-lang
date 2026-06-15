# 0490 — Email format

Validate a model with the FluentValidation library, enforcing that `Email` is a well-formed address via the `EmailAddress()` rule. The validator runs against the fixed input `{ Email = "not-an-email" }`; the output is the failing field name(s) extracted from `result.Errors` (lowercased, de-duplicated, and sorted), or `ok` when validation passes.

## Run

    dotnet run

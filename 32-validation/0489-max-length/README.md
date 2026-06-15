# 0489 — Maximum length

Uses FluentValidation's `AbstractValidator<Model>` with `RuleFor(x => x.Code).MaximumLength(5)` to enforce that `Code` is at most 5 characters. The input `{code: "ABCDEFG"}` is 7 characters, so it violates the constraint and `Validate` records an error. The output is the sorted, lowercased failing field name(s) extracted from the validator's error result, or `ok` when validation passes.

## Run

    dotnet run

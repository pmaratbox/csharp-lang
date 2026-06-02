# 0013 — Optional

Hold one value that is present (`42`) and one that is absent, then print each
with a fallback of `-1` when absent. `int?` is shorthand for `Nullable<int>`,
making a value type able to hold `null`. The null-coalescing operator `??`
unwraps the value or substitutes the fallback when it is `null`, without
clobbering a legitimate `0`.

## Run

    dotnet run

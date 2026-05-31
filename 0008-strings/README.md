# 0008 — Strings

Given `name = "world"`, print a greeting, the name in uppercase, and its
length. `$"..."` is an interpolated string, splicing values into `{}`
placeholders. `string` is immutable, so `.ToUpper()` returns a new string. The
`.Length` property counts UTF-16 code units (`char`), which equals the
character count for ASCII.

## Run

    dotnet run

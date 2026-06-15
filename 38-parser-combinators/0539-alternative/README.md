# 0539 — Alternative

Using the **Sprache** parser-combinator library, build a choice parser with the
**`.Or(...)`** combinator: it tries the literal `cat` parser first and, if that
fails, falls back to the literal `dog` parser. Running the combined parser on the
fixed input `dog` matches the second alternative and prints `dog`.

## Run

    dotnet run

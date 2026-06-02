# 0041 — Command-line Arguments

Read the first command-line argument and greet it, so running with `Ada` prints `hello, Ada`. Top-level statements expose the arguments as the implicit `args` array (no program-name slot), so `args[0]` is the first. `dotnet run Ada` forwards `Ada` to the program.

## Run

    dotnet run Ada

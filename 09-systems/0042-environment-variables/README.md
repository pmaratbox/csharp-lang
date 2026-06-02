# 0042 — Environment Variables

Read the environment variable `LESSON_ENV_VAR`, falling back to `default` when it is unset, and print `value: default`. `Environment.GetEnvironmentVariable(name)` returns `null` when the variable is unset, and `??` supplies the default. An overload can scope the lookup to the process, user, or machine.

## Run

    dotnet run

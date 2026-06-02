# 0036 — Inheritance & Overriding

Define a base `Animal` with a `speak` method, a `Dog` that overrides it, and call both, printing `animal: some sound` and `dog: Woof`. `virtual` on the base method and `override` on `Dog`'s enable runtime dispatch (methods are non-virtual by default in C#). `base.Speak()` reaches the parent, and `sealed` can stop further overriding.

## Run

    dotnet run

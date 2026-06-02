# 0045 — Abstract Classes & Methods

Define an abstract `Shape` with an abstract `area` and a concrete `describe` that uses it, then implement a `Square` of side 3 and print `area: 9`. An `abstract class` with an `abstract` method cannot be instantiated and obliges `Square` to `override Area`; the concrete `Describe` is inherited and dispatches to it. `Square(int side)` is a primary constructor.

## Run

    dotnet run

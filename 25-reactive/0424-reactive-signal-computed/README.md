# 0424 — Signal + Computed

Implement fine-grained reactivity: a writable signal and a derived computed that recomputes when its dependency changes. The computed subscribes an `Action` recompute callback to each `Signal<T>` and lazily re-evaluates a cached value when marked dirty.

## Run

    dotnet run

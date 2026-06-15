# 0481 — Loop over objects

Render a fixed template with the **Scriban** engine that iterates a list of objects. The `{{ for u in users }}...{{ end }}` block walks the `users` array, and inside the loop `{{ u.name }}: {{ u.age }}` reads each object's properties. The loop helper `{{ if !for.last }}\n{{ end }}` inserts a newline between items but not after the final one, so the output is `alice: 30` then `bob: 25` joined by a single newline with no trailing newline.

## Run

    dotnet run

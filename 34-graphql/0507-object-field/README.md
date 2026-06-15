# 0507 — Object field

Uses HotChocolate's in-process request executor to define a schema with an object type `User { name: String }` exposed by `type Query { user: User }`. The `Query.GetUser` resolver returns a `User` object, and HotChocolate maps the C# type to the GraphQL object type. The query `{ user { name } }` is executed in-process (no HTTP server), and the printed value is read out of the execution result's nested `data.user.name`, not hardcoded.

## Run

    dotnet run

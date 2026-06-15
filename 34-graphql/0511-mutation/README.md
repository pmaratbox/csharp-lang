# 0511 — Mutation

Uses HotChocolate's in-process request executor to define a schema with a `Mutation` type. The `Mutation.AddUser(name)` resolver returns a `User` object, with HotChocolate mapping the C# method to the GraphQL field `addUser(name: String!): User` and the parameter to the field argument. The mutation `mutation { addUser(name: "bob") { name } }` is executed in-process (no HTTP server), and the printed value is read out of the execution result's nested `data.addUser.name`, not hardcoded.

## Run

    dotnet run

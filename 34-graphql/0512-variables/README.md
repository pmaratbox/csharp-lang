# 0512 — Query variables

This lesson uses the HotChocolate GraphQL library to execute a query in-process with GraphQL variables. The document declares an `$id: Int!` variable, and the value `42` is supplied separately through the execution's variable values map (via `OperationRequestBuilder.SetVariableValues`) rather than being interpolated into the query string. The `item(id: $id)` resolver receives the bound argument and returns an `Item` whose `id` is read back from the resolved data.

## Run

    dotnet run

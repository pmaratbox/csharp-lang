Result SafeDiv(int a, int b) =>
    b == 0 ? new Err("divide by zero") : new Ok(a / b);

void Print(Result r) => Console.WriteLine(r switch
{
    Ok(var v) => $"ok: {v}",
    Err(var m) => $"err: {m}",
    _ => "",
});

Print(SafeDiv(10, 2));
Print(SafeDiv(1, 0));

abstract record Result;
sealed record Ok(int Value) : Result;
sealed record Err(string Message) : Result;

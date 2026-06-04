var table = new Dictionary<string, Func<int, int, int>>
{
    ["add"] = (a, b) => a + b,
    ["mul"] = (a, b) => a * b,
};

Console.WriteLine($"{table["add"](3, 4)} {table["mul"](3, 4)}");

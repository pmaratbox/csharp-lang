Func<int, int, int> Select(string name) => name switch
{
    "add" => (a, b) => a + b,
    "mul" => (a, b) => a * b,
    _ => throw new ArgumentException($"unknown strategy: {name}"),
};

var add = Select("add");
var mul = Select("mul");
Console.WriteLine($"{add(3, 4)} {mul(3, 4)}");

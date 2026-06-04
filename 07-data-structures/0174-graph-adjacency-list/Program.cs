var adjacency = new List<int>[]
{
    new() { 1, 2 },
    new() { 0, 3 },
    new() { 0, 3 },
    new() { 1, 2 },
};

Console.WriteLine(string.Join(" ", adjacency[0]));

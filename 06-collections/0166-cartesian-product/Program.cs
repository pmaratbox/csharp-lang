int[] xs = [1, 2];
string[] ys = ["a", "b"];

var pairs =
    from x in xs
    from y in ys
    select $"{x}{y}";

Console.WriteLine(string.Join(" ", pairs));

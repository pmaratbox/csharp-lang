var next = new Dictionary<string, string>
{
    ["A"] = "B",
    ["B"] = "C",
    ["C"] = "A",
};

var state = "A";
var seen = new List<string>();
for (var i = 0; i < 3; i++)
{
    state = next[state];
    seen.Add(state);
}

Console.WriteLine(string.Join(' ', seen));

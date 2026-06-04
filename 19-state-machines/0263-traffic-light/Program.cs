var next = new Dictionary<string, string>
{
    ["red"] = "green",
    ["green"] = "yellow",
    ["yellow"] = "red",
};

var state = "red";
var seen = new List<string>();
for (var i = 0; i < 4; i++)
{
    state = next[state];
    seen.Add(state);
}

Console.WriteLine(string.Join(' ', seen));

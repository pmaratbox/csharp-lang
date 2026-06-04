static string Step(string state, string evt) => (state, evt) switch
{
    ("locked", "coin") => "unlocked",
    ("unlocked", "push") => "locked",
    ("locked", "push") => "locked",
    _ => state,
};

var state = "locked";
var seen = new List<string>();
foreach (var evt in new[] { "coin", "push", "push" })
{
    state = Step(state, evt);
    seen.Add(state);
}

Console.WriteLine(string.Join(' ', seen));

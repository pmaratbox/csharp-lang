var targets = new[] { 2, 0 };
var floor = 0;
var stops = new List<int> { floor };

foreach (var target in targets)
{
    while (floor != target)
    {
        floor += Math.Sign(target - floor);
        stops.Add(floor);
    }
}

Console.WriteLine(string.Join(' ', stops));

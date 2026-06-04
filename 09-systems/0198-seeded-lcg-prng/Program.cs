var outputs = new List<int>();
var x = 1;
for (var i = 0; i < 3; i++)
{
    x = (5 * x + 3) % 16;
    outputs.Add(x);
}

Console.WriteLine(string.Join(' ', outputs));

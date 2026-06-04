const string text = "hello";
var counts = new Dictionary<char, int>();
foreach (var c in text)
    counts[c] = counts.GetValueOrDefault(c) + 1;

char best = text[0];
int bestCount = 0;
foreach (var c in text)
{
    if (counts[c] > bestCount)
    {
        bestCount = counts[c];
        best = c;
    }
}
Console.WriteLine(best);

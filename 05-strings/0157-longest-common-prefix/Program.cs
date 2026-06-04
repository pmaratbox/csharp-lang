string[] words = ["flower", "flow", "flight"];
string prefix = words[0];
foreach (var w in words)
{
    int i = 0;
    while (i < prefix.Length && i < w.Length && prefix[i] == w[i])
        i++;
    prefix = prefix[..i];
}
Console.WriteLine(prefix);

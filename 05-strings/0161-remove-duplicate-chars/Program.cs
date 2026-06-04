const string text = "aabbcc";
var seen = new HashSet<char>();
var sb = new System.Text.StringBuilder();
foreach (var c in text)
    if (seen.Add(c))
        sb.Append(c);
Console.WriteLine(sb.ToString());

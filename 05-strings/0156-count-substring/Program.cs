const string text = "ababab";
const string needle = "ab";
int count = 0, i = 0;
while ((i = text.IndexOf(needle, i, StringComparison.Ordinal)) >= 0)
{
    count++;
    i += needle.Length;
}
Console.WriteLine(count);

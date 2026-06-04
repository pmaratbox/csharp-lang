int mask = 5;
var subs = new List<int>();
for (int sub = mask; ; sub = (sub - 1) & mask)
{
    subs.Add(sub);
    if (sub == 0) break;
}
Console.WriteLine(string.Join(" ", subs));

string s = "babad";

int bestStart = 0, bestLen = 1;

void Expand(int l, int r)
{
    while (l >= 0 && r < s.Length && s[l] == s[r])
    {
        l--;
        r++;
    }
    int len = r - l - 1;
    if (len > bestLen)
    {
        bestLen = len;
        bestStart = l + 1;
    }
}

for (int i = 0; i < s.Length; i++)
{
    Expand(i, i);
    Expand(i, i + 1);
}

Console.WriteLine(s.Substring(bestStart, bestLen));

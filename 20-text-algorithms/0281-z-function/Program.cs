string s = "aaaa";
int n = s.Length;
int[] z = new int[n];
int l = 0, r = 0;
for (int i = 1; i < n; i++)
{
    if (i < r) z[i] = Math.Min(r - i, z[i - l]);
    while (i + z[i] < n && s[z[i]] == s[i + z[i]]) z[i]++;
    if (i + z[i] > r)
    {
        l = i;
        r = i + z[i];
    }
}

Console.WriteLine(string.Join(' ', z.Skip(1)));

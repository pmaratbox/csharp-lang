string text = "ababab";
string pattern = "ab";

int[] BuildPrefix(string p)
{
    int[] pi = new int[p.Length];
    int k = 0;
    for (int i = 1; i < p.Length; i++)
    {
        while (k > 0 && p[i] != p[k]) k = pi[k - 1];
        if (p[i] == p[k]) k++;
        pi[i] = k;
    }
    return pi;
}

int[] pi = BuildPrefix(pattern);
List<int> matches = new();
int q = 0;
for (int i = 0; i < text.Length; i++)
{
    while (q > 0 && text[i] != pattern[q]) q = pi[q - 1];
    if (text[i] == pattern[q]) q++;
    if (q == pattern.Length)
    {
        matches.Add(i - pattern.Length + 1);
        q = pi[q - 1];
    }
}

Console.WriteLine(string.Join(' ', matches));

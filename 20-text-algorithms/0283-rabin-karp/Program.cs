string text = "xabxab";
string pattern = "ab";

const int baseVal = 256;
const long mod = 1_000_000_007;
int m = pattern.Length;

long Pow(long b, int e)
{
    long r = 1;
    for (int i = 0; i < e; i++) r = r * b % mod;
    return r;
}

long high = Pow(baseVal, m - 1);

long patHash = 0, winHash = 0;
for (int i = 0; i < m; i++)
{
    patHash = (patHash * baseVal + pattern[i]) % mod;
    winHash = (winHash * baseVal + text[i]) % mod;
}

List<int> matches = new();
for (int i = 0; i + m <= text.Length; i++)
{
    if (i > 0)
    {
        winHash = ((winHash - text[i - 1] * high % mod + mod) % mod * baseVal + text[i + m - 1]) % mod;
    }
    if (winHash == patHash && text.Substring(i, m) == pattern)
        matches.Add(i);
}

Console.WriteLine(string.Join(' ', matches));

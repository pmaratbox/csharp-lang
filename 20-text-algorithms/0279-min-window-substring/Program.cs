string s = "ADOBECODEBANC";
string t = "ABC";

Dictionary<char, int> need = new();
foreach (char c in t)
    need[c] = need.GetValueOrDefault(c) + 1;

int required = need.Count;
int formed = 0;
Dictionary<char, int> window = new();

int bestLen = int.MaxValue, bestStart = 0;
int left = 0;

for (int right = 0; right < s.Length; right++)
{
    char c = s[right];
    window[c] = window.GetValueOrDefault(c) + 1;
    if (need.ContainsKey(c) && window[c] == need[c])
        formed++;

    while (formed == required)
    {
        if (right - left + 1 < bestLen)
        {
            bestLen = right - left + 1;
            bestStart = left;
        }
        char lc = s[left];
        window[lc]--;
        if (need.ContainsKey(lc) && window[lc] < need[lc])
            formed--;
        left++;
    }
}

Console.WriteLine(s.Substring(bestStart, bestLen));
